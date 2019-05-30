using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebsite.Models
{
    public class UserModel
    {
        [DisplayName("username")]
        [Required(ErrorMessage = "username cannot be blank")]
        public string username { get; set; }
       

        [DisplayName("password")]
        [Required(ErrorMessage = "password cannot be blank")]
        public string password { get; set; }
     
    }
}
