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
            //i dont have username as part of my pizorder class
            //Username = pizorder.username
            
        };

    }
}
