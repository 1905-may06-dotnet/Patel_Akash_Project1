using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebsite.Models
{
    public class PizzaModel
    {
        //pizza string containing entire pizza
        [Display(Name = "Pizza")]
        public string Pizza { get; set; }

        //pizza topping array containing all toppings
        [Display(Name = "PizzaToppings")]
        public List<string> PizzaToppings { get; set; }


        [Display(Name = "Pizza Size")]
        public string PizzaSize { get; set; }

        [Display(Name = "Pizza Crust")]
        public string PizzaCrust { get; set; }

        [Display(Name = "PizzaTopping1")]
        public string PizzaTopping1 { get; set; }

        [Display(Name = "PizzaTopping2")]
        public string PizzaTopping2 { get; set; }

        [Display(Name = "PizzaTopping3")]
        public string PizzaTopping3 { get; set; }

        [Display(Name = "PizzaTopping4")]
        public string PizzaTopping4 { get; set; }

        [Display(Name = "PizzaTopping5")]
        public string PizzaTopping5 { get; set; }

        [Display(Name = "PizzaCost")]
        public double PizzaCost { get; set; }

        [Display(Name ="PizzaQuantity")]
        public int PizzaQuantity { get; set; }




    }
}
