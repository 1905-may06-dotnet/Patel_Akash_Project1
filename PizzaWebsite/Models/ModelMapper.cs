using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebsite.Models
{
    public class ModelMapper
    {
        public static OrderModel Map(Pizzaboxdomain.PizzaOrder pizorder) => new OrderModel
        {
            OrderDateTime = pizorder.OrderDatetime,
            Location = pizorder.LocationAddress,
            OrderTotalCost = pizorder.totalpizzacost,
            Username = pizorder.username,
            OrderID = pizorder.orderID
        };

        public static LocationModel Map(Pizzaboxdomain.PizzaLocations pizloc) => new LocationModel
        {
            PizzaCheese = pizloc.PizzaCheese,
            PizzaDough = pizloc.PizzaDough,
            PizzaSauce = pizloc.PizzaSauce,
            Bellpeppers = pizloc.bellpeppers,
            Mushrooms = pizloc.Mushrooms,
            Jalapenos = pizloc.jalapeno,
            Spinach = pizloc.spinach,
            Onions = pizloc.onions
        };

    }
}
