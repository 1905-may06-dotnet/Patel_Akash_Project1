using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PizzaWebsite.Models
{
    public class LocationModel
    {

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "PizzaDough")]
        public int PizzaDough { get; set; }

        [Display(Name = "PizzaCheese")]
        public int PizzaCheese { get; set; }

        [Display(Name = "PizzaSauce")]
        public int PizzaSauce { get; set; }

        [Display(Name = "Mushrooms")]
        public int Mushrooms { get; set; }

        [Display(Name = "Onions")]
        public int Onions { get; set; }

        [Display(Name = "Bellpeppers")]
        public int Bellpeppers { get; set; }

        [Display(Name = "Spinach")]
        public int Spinach { get; set; }

        [Display(Name = "Jalapeno")]
        public int Jalapenos { get; set; }



    }

   

}
