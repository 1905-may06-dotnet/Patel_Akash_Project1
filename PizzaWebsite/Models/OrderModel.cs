using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaWebsite.Models
{
    public class OrderModel
    {

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "OrderID")]
        public int OrderID { get; set; }


        [Display(Name = "OrderTotalCost")]
        public double OrderTotalCost { get; set; }

        [Display(Name = "Order DateTime")]
        public DateTime OrderDateTime { get; set; }

        [Display(Name = "Username")]
        public string Username { get; set; }

        /*
        public static OrderModel Map(Pizzaboxdomain.PizzaOrder pizzaOrder) => new OrderModel()
        {
            OrderDateTime = pizzaOrder.OrderDatetime,
            OrderTotalCost = pizzaOrder.gettotalpizzacost(),

            

        };
        */

        
    }
}
