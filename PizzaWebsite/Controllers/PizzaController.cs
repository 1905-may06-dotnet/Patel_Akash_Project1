using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizzaboxdata.Data;
using Pizzaboxdomain;

namespace PizzaWebsite.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IUserRepository PC;

        //intialize context
        public PizzaController(IUserRepository PC)
        {
            this.PC = PC;
        }

       
       

        
    }
}