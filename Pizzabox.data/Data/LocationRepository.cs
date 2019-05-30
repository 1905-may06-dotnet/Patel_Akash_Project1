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
    public class LocationRepository
    {
        private readonly PizzaContext PC;

        public bool canOrder(string location, string username)
        {
            int compare; //intialize comparison integer
            DateTime lastOrder; //intiialize datetime variable


            //this last part is a check on where the user has ordered in the last 24 hours or in the last 2 hours
            //the below statement returns the entry that has the users most recent order
            OrderTable x = PC.OrderTable.Where<OrderTable>(u => u.UsernameFk == username).OrderByDescending(y => y.OrderDateTime).FirstOrDefault<OrderTable>();
            lastOrder = (DateTime)x.OrderDateTime;

            //step 0, check to see if the user had a last order at all
            if (x == null)
            {
                //if theres no last order, we know that the user can order at this location
                return true;
            }
            //step 1, check to see if the user has ordered within the last 2 hours
            else if (((DateTime.Now).CompareTo(lastOrder.AddHours(2.00))<0.00))
            {
                //if the above statement is true, this means that the last order was less than 2hours ago
                //so we return false
                return false;
            }
            else
            {
                //Step 2, add 24 hours to the datetime obtained in step 1 and compare that to the current datetime.  If the result
                //is less than 0 prompt the user that they cannot order at the current location because they have ordered within 24 hours
                //also set cont to false so that this loop does not end.  If they have not ordered within 24hours, do nothing and let the 
                //loop terminate as usual.
                //cast datetime in database to datetime time.


                //compare users last order plus 24 hours to current time.
                compare = (DateTime.Now).CompareTo(lastOrder.AddHours(24.00));
                if (compare >= 0)
                {
                    //this means that the users last order was at least 24 hours ago
                    //so that means we don't need to do anything since the order is valid
                    return true;
                }
                else
                {
                    //this means the user has ordered within the last 24 hours
                    //so we need to make sure that they are ordering at the same location
                    //the 2hour check was done earlier before reaching this point so we dont need to worry about that

                    //first we perform a sql query to determine the location of the last order
                    x = PC.OrderTable.Where<OrderTable>(u => u.UsernameFk == username).OrderByDescending(y => y.OrderDateTime).FirstOrDefault<OrderTable>();
                    string lastlocation = x.LocationFk;

                    if (location.Equals(lastlocation))
                    {
                        //if they are ordering at the same location return true
                        return true;
                    }
                    else
                    {
                        //user is trying to order at another location, this is not allowed return false
                        return false;
                    }

                }
            }
        }

        //i dont know if i should put this here or not, or if i need it but here it is
        public void viewOrders(PizzaContext PC, string location)
        {
            int i = 0;
            var x = PC.OrderTable.Where<OrderTable>(u => u.LocationFk.Equals(location)).ToList();
            foreach (var obj in x)
            {

                obj.displayOrderDetails();
                //x[i].orderIDpk contains the orderID primary key, so im searching the pizza table for entries that match the
                // order id
                var y = PC.PizzaTable.Where<PizzaTable>(u => u.OrderIdFk.Equals(x[i].OrderIdPk));

                foreach (var obj2 in y)
                {
                    obj2.displayPizzaDetails();

                }
                i += 1;
            }


        }

        //i dont know if i should put this here or not, or if i need it but here it is
        public void viewInventory(PizzaContext PC, string location)
        {
            var x = PC.LocationTable.Where<LocationTable>(u => u.LocationPk.Equals(location)).ToList();
            foreach (var obj in x)
            {
                obj.displayLocationDetails();
            }
        }

        //i dont know if i should put this here or not, or if i need it but here it is
        public void viewUsers(PizzaContext PC, string location)
        {
            var x = PC.OrderTable.Where<OrderTable>(u => u.LocationFk.Equals(location)).Select(z => z.UsernameFk).Distinct().ToList();
            int i = 1;
            foreach (var obj in x)
            {
                Console.WriteLine($"User {i}: {obj}");
                i += 1;
            }
        }


    }

}
