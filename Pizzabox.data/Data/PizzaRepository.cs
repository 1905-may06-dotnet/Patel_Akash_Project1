using Microsoft.EntityFrameworkCore;
using Pizzaboxdomain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaboxdata.Data
{
    /// <summary>
    /// A repository managing data access for restaurant objects and their review members.
    /// </summary>
    /// <remarks>
    /// This class ought to have better exception handling and logging.
    /// </remarks>
    public class PizzaRepository : IPizzaRepository
    {
        private readonly PizzaContext PC;

        /// <summary>
        /// Initializes a new restaurant repository given a suitable Entity Framework DbContext.
        /// </summary>
        /// <param name="db">The DbContext</param>
        public PizzaRepository()
        {
            PC = new PizzaContext();
            
        }
        ~PizzaRepository()
        {
            PC.Dispose();
        }

        /* I dont know how to fix this error so I am disabling
        /// <summary>
        /// Get all PizzaOrders with deferred execution.
        /// </summary>
        /// <returns>The collection of restaurants</returns>
        public IEnumerable<PizzaOrder> GetPizzaOrder(string search = null)
        {
            if (search == null)
            {
                // disable pointless tracking for performance
                return Mapper.Map(PC.OrderTable.Include(r => r.UsernameFk).AsNoTracking());
            }
            else
            {
                return Mapper.Map(PC.OrderTable.Include(r => r.UsernameFk)
                    .AsNoTracking().Where(r => r.UsernameFk.Contains(search)));
            }
        }
        */

        /// <summary>
        /// Get a restaurant by ID.
        /// </summary>
        /// <returns>The restaurant</returns>
        public PizzaOrder GetPizzaOrderById(int id)
        {
            // disable pointless tracking for performance
            return Mapper.Map(PC.OrderTable.Include(r => r.OrderIdPk)
                .AsNoTracking().First(r => r.OrderIdPk == id));
        }

        /// <summary>
        /// Add a restaurant, including any associated reviews.
        /// </summary>
        /// <param name="pizzaorder">The restaurant</param>
        public void AddRestaurant(PizzaOrder pizzaorder)
        {
            PC.Add(Mapper.Map(pizzaorder));
        }

        /// <summary>
        /// Delete a restaurant by ID, including any reviews associated to it.
        /// </summary>
        /// <param name="orderId">The ID of the restaurant</param>
        public void DeletePizzaOrder(int orderId)
        {
            PC.Remove(PC.OrderTable.Find(orderId));
        }

        /* NOTE I am not implementing this case because I do not think it is required for my application
        /// <summary>
        /// Update a restaurant. Will not process any changes to its reviews.
        /// </summary>
        /// <param name="pizzaorder">The restaurant with changed values</param>
        public void UpdateRestaurant(PizzaOrder pizzaorder)
        {
            // calling Update would mark every property as Modified.
            // this way will only mark the changed properties as Modified.
            PC.Entry(PC.OrderTable.Find(pizzaorder.)).CurrentValues.SetValues(Mapper.Map(restaurant));
        }
        */

        /// <summary>
        /// Get a review.
        /// </summary>
        /// <param name="pizzaId">The ID of the review</param>
        public Pizza GetPizzaById(int pizzaId)
        {
            return Mapper.Map(PC.PizzaTable.AsNoTracking().First(r => r.PizzaIdPk == pizzaId));
        }


        /* Not going to implement because I do not think it is required

        /// <summary>
        /// Add a review, and optionally associate it with a restaurant.
        /// </summary>
        /// <param name="pizza">The pizza</param>
        /// <param name="pizzaorder">The pizzaorder (or null if none)</param>
        public void AddPizza(Pizza pizza, PizzaOrder pizzaorder)
        {
            if (pizzaorder != null)
            {
                // get the db's version of that pizzaorder
                // (can't use Find with Include)
                PizzaOrder contextPizzaOrder = PC.OrderTable.Include(r => r.PizzaTable)
                    .First(r => r.OrderIdPk == PizzaTable.);
                restaurant.Reviews.Add(review);
                contextRestaurant.Review.Add(Mapper.Map(review));
            }
            else
            {
                _db.Add(Mapper.Map(review));
            }
        }
        */

        /// <summary>
        /// Delete a Pizza by ID.
        /// </summary>
        /// <param name="pizzaId">The ID of the review</param>
        public void DeletePizza(int pizzaId)
        {
            PC.Remove(PC.PizzaTable.Find(pizzaId));
        }
        /* Not going to implement this
        /// <summary>
        /// Update a review.
        /// </summary>
        /// <param name="pizza">The review with changed values</param>
        public void UpdatePizza(Pizza review)
        {
            _db.Entry(_db.Review.Find(review.Id)).CurrentValues.SetValues(Mapper.Map(review));
        }
        */

        /// <summary>
        /// Get the ID of the restaurant associated to the review with the given ID.
        /// this is probably not working propery and will need to be rewritten
        /// </summary>
        /// <param name="pizzaorderId">The ID of the review</param>
        /// <returns></returns>
        public int RestaurantIdFromReviewId(int pizzaorderId)
        {
            return PC.PizzaTable.AsNoTracking().First(r => r.OrderIdFk == pizzaorderId).PizzaIdPk;
        }

        /// <summary>
        /// Persist changes to the data source.
        /// </summary>
        public void Save()
        {
            PC.SaveChanges();
        }

        //record pizza order to order table and pizza table
        public bool AddPizzaOrder(PizzaOrder pizzaOrder, PizzaUser user)
        {
            //first determine if the pizzaOrder is legit and can be added
            if (pizzaOrder.checkCost() && pizzaOrder.checkCount())
            {
                //enter order in the database
                //step 0, find out what value i want for primary key since SQL wont do it for me
                int orderID = 0; //initialize order id variable

                OrderTable x = PC.OrderTable.OrderByDescending(y => y.OrderIdPk).FirstOrDefault<OrderTable>();
                if (x == null)
                {
                    orderID = 0;
                }
                else
                {
                    orderID = x.OrderIdPk + 1;
                }



                //step 1, enter the Order into the OrderTable
                OrderTable O = new OrderTable() { UsernameFk = user.username, LocationFk = pizzaOrder.LocationAddress, OrderDateTime = DateTime.Now, OrderTotalCost = pizzaOrder.gettotalpizzacost(), OrderIdPk = orderID };
                PC.OrderTable.Add(O);
                PC.SaveChanges();






                //step 1.5 find out what value i want for primary key for pizzaDB since SQL wont do it for me
                int PizzaID = 0;
                PizzaTable z = PC.PizzaTable.OrderByDescending(y => y.PizzaIdPk).FirstOrDefault<PizzaTable>();
                if (z == null)
                {
                    PizzaID = 0;
                }
                else
                {
                    PizzaID = z.PizzaIdPk + 1;
                }


                //step 2, enter the Pizzas into the PizzaTable
                for (int i = 0; i < pizzaOrder.pizzalist.Count(); i++)
                {

                    PizzaTable P = new PizzaTable() { PizzaString = pizzaOrder.pizzalist[i].showPizza(), PizzaCount = pizzaOrder.pizzalist[i].quantity, OrderIdFk = orderID, PizzaIdPk = PizzaID + i };
                    PC.PizzaTable.Add(P);
                    PC.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<PizzaOrder> searchbyLocation(string loc)
        {
            var x = PC.OrderTable.Where<OrderTable>(u => u.LocationFk.Equals(loc));

            var y = x.Select(order => Mapper.Map(order)).ToList();

            return y;
        }

        public List<PizzaOrder> searchbyUsername(string username)
        {
            var x = PC.OrderTable.Where<OrderTable>(u => u.UsernameFk.Equals(username));

            var y = x.Select(order => Mapper.Map(order)).ToList();

            return y;
        }

        public PizzaLocations getInventorybyloc(string loc)
        {
            var x = PC.LocationTable.Where<LocationTable>(u => u.LocationPk.Equals(loc)).FirstOrDefault();
            var y = Mapper.Map(x);
            return y;
        }

        public List<PizzaOrder> getUserbyloc(string loc)
        {
            var x = PC.OrderTable.Where<OrderTable>(u => u.LocationFk.Equals(loc));
            
            var y = x.Select(order => Mapper.Map(order)).ToList();
            return y;

        }

        public bool CheckOrderConditions(string Location, string username)
        {
            //initialize booleans to check all order conditions
            DateTime lastOrder;


            //this method is a bit wonky
            int compare = 0; //int used to determine if user has ordered within last two hours
                             //Check if it has been 2 hours since the user last ordered a pizza

            //step 1 determine when the user's last order was
            //get the row of their last order by using firstordefault in conduction with an order by
            OrderTable x = PC.OrderTable.Where<OrderTable>(u => u.UsernameFk == username).OrderByDescending(y => y.OrderDateTime).FirstOrDefault<OrderTable>();

            //check to see if the user had a last order at all
            if (x == null)
            {
                return true;
            }
            else
            {
                //cast datetime in database to datetime time.
                lastOrder = (DateTime)x.OrderDateTime;

                //compare users last order plus 2 hours to current time.
                compare = (DateTime.Now).CompareTo(lastOrder.AddHours(2.00));
                if (compare >= 0)
                {
                    //this means that the users last order was at least 2 hours ago
                    //so now we need to check if they are ordering at the same place
                }
                else
                {
                    //this means the user has ordered within the last 2 hours
                    return false;
                   
                }
            }

            //if the users last order more than 2 hours ago, make sure they are ordering at the same place
            compare = 0; //reset int compare to zero
            compare = (DateTime.Now).CompareTo(lastOrder.AddHours(24.00));
            if (compare >= 0)
            {
                //this means that the users last order was at least 24 hours ago
                return true;
            }
            else
            {
                //this means the user has ordered within the last 24 hours so we need to 
                //make sure they are ordering at the same location
                x = PC.OrderTable.Where<OrderTable>(u => u.LocationFk == Location).OrderByDescending(y => y.OrderDateTime).FirstOrDefault<OrderTable>();
                if(x.LocationFk.Equals(Location))
                {
                    //this means they are ordering at the same place, so its ok
                    return true;
                }
                else
                {
                    //this means they are ordering at a different place so its not ok
                    return false;
                }


            }


            
        }


    }
}
