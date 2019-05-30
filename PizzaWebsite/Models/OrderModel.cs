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
        
            [Display(Name = "ID")]
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

        //    public IEnumerable<Review> Reviews { get; set; }

            [DisplayFormat(DataFormatString = "{0:#.##}")]
            public double? Score { get; set; }
        
    }
}
