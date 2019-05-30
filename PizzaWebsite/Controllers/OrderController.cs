using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizzaboxdata.Data;
using Pizzaboxdomain;

namespace PizzaWebsite.Controllers
{
    public class OrderController : Controller
    {
        private readonly IPizzaRepository PC;
        public string currentUser = "";

        //intialize context
        public OrderController(IPizzaRepository PC)
        {
            this.PC = PC;
        }


        //initialize new ordermodel
        Models.OrderModel order;
        List<Models.OrderModel> OrderList = new List<Models.OrderModel>();
        




        public IActionResult Index()
        {
            return View();
        }


        public ActionResult AdminData(/*Models.LocationModel loc*/)
        {
            //List<PizzaOrder> x = PC.searchbyLocation(loc.Location).ToList();
            return View(/*x*/);
        }

        public IActionResult CustomOrPreset()
        {
            //display to username their location and name
            ViewData["location"]= HttpContext.Session.GetString("location");
            ViewData["username"] = HttpContext.Session.GetString("username");
            return View();
        }
    }
}