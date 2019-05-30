using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PizzaWebsite.Models
{
    public class LocationModel
    {

        [Required]
        public string location { get; set; }

    }

   

}
