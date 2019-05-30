using System;
using System.Collections.Generic;
using System.Text;


namespace Pizzaboxdomain
{
    


        /// <summary>
        /// A repository managing data access for PizzaOrder objects and their Pizza members.
        /// </summary>
        public interface IPizzaRepository
        {
        /* Maybe implement later
            /// <summary>
            /// Get all PizzaOrders with deferred execution, including any associated Pizzas.
            /// </summary>
            /// <returns>The collection of PizzaOrders</returns>
            IEnumerable<PizzaOrder> GetPizzaOrders(string search);
            */

            /// <summary>
            /// Get a PizzaOrder, including any associated Pizzas.
            /// </summary>
            /// <param name="restaurant">The restaurant</param>
            PizzaOrder GetPizzaOrderById(int id);


        /* May need to implement this later
            /// <summary>
            /// Add a PizzaOrder, including any associated Pizzas.
            /// </summary>
            /// <param name="pizzaorder">The restaurant</param>
            void AddPizzaOrder(PizzaOrder pizzaorder);

            */

            /// <summary>
            /// Delete a PizzaOrder by ID, including any Pizzas associated to it.
            /// </summary>
            /// <param name="OrderId">The ID of the restaurant</param>
            void DeletePizzaOrder(int OrderId);

        /* NOTE I am not implementing this case because I do not think it is required for my application
            /// <summary>
            /// Update a PizzaOrder. Will not process any changes to its Pizza.
            /// </summary>
            /// <param name="pizzaorder">The restaurant with changed values</param>
            void UpdatePizzaOrder(PizzaOrder pizzaorder);
            */

            /// <summary>
            /// Get a pizza.
            /// </summary>
            /// <param name="PizzaId">The ID of the review</param>
            Pizza GetPizzaById(int PizzaId);

        /* Not going to implement
            /// <summary>
            /// Add a Pizza, and optionally associate it with a PizzaOrder.
            /// </summary>
            /// <param name="pizza">The the pizza</param>
            /// <param name="pizzaorder">The pizzaorder (or null if none)</param>
            void AddPizza(Pizza pizza, PizzaOrder pizzaorder);
            */

            /// <summary>
            /// Delete a review by ID.
            /// </summary>
            /// <param name="pizzaId">The ID of the review</param>
            void DeletePizza(int pizzaId);

        /* Not going to implement this
            /// <summary>
            /// Update a pizza.
            /// </summary>
            /// <param name="pizza">The review with changed values</param>
            void UpdatePizza(Pizza pizza);
            */


            /* might need to implement later
            /// <summary>
            /// Get the ID of the PizzaOrder associated to the Pizza with the given ID.
            /// </summary>
            /// <param name="pizzaId">The ID of the review</param>
            /// <returns></returns>
            int PizzaOrderIdFromPizzaId(int pizzaId);
            */

            /// <summary>
            /// Persist changes to the data source.
            /// </summary>
            void Save();
        }
    

}
