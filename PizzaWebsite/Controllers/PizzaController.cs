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

       
        

       Models.PizzaModel user;
       List<Models.PizzaModel> UserList = new List<Models.PizzaModel>();

        public ActionResult UserPreset(Models.PizzaModel pizzamodel)
        {
            bool temp = false;

            Pizzaboxdomain.Pizza piz = new Pizza();
            piz.crust = pizzamodel.PizzaCrust;
            piz.size = pizzamodel.PizzaSize;
            piz.quantity = pizzamodel.PizzaQuantity;
            List<String> templist = new List<string>() { pizzamodel.PizzaTopping1, pizzamodel.PizzaTopping2, pizzamodel.PizzaTopping3, pizzamodel.PizzaTopping4, pizzamodel.PizzaTopping5 };
            //remove blank entries from templist
            templist = templist.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            piz.toppings = templist;
            //create pizzastring
            piz.PizzaString = piz.showPizza();

            return View();

        }
    }
}