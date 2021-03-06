﻿using System;
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
        //intialize temp pizzalist to hold pizzas that user makes
        public PizzaOrder tempOrder = new PizzaOrder();
      

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


        public ActionResult AdminOrderData(Models.LocationModel loc)
        {

            List<Pizzaboxdomain.PizzaOrder> x = PC.searchbyLocation(loc.Location);
            List<PizzaWebsite.Models.OrderModel> y = new List<PizzaWebsite.Models.OrderModel>();
            foreach(var item in x)
            {
                y.Add(PizzaWebsite.Models.ModelMapper.Map(item));
            }
            ViewData["adminlocation"] = HttpContext.Session.GetString("adminlocation");
            
            return View(y);
        }

        public ActionResult AdminInventoryData(Models.LocationModel loc)
        {
            ViewData["adminlocation"] = HttpContext.Session.GetString("adminlocation");
            var x = PC.getInventorybyloc(loc.Location);
            PizzaWebsite.Models.LocationModel y = PizzaWebsite.Models.ModelMapper.Map(x);
            return View(y);
        }

        public ActionResult AdminUserData(Models.LocationModel loc)
        {
          ViewData["adminlocation"] = HttpContext.Session.GetString("adminlocation");
            var x = PC.getUserbyloc(loc.Location);
            List<PizzaWebsite.Models.OrderModel> y = new List<PizzaWebsite.Models.OrderModel>();
            foreach (var item in x)
            {
                
                y.Add(PizzaWebsite.Models.ModelMapper.Map(item));
            }

            List<string> userlist = new List<string>();

            for(int i = 0; i<y.Count(); i++)
            {
                userlist.Add(y[i].Username);
            }
            userlist.Distinct();

            return View(userlist);

        }


        //page that routes user to make either a custom or preset pizza;
        public IActionResult CustomOrPreset()
        {
            //display to username their location and name
            ViewData["location"]= HttpContext.Session.GetString("location");
            ViewData["username"] = HttpContext.Session.GetString("username");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserPreset(Models.PizzaModel pizzamodel)
        {

            //create pizza
            Pizzaboxdomain.Pizza piz = new Pizza();


            piz.crust = pizzamodel.PizzaCrust;
            piz.size = pizzamodel.PizzaSize;
            piz.quantity = pizzamodel.PizzaQuantity;
            List<String> templist = new List<string>() {pizzamodel.PizzaTopping1, pizzamodel.PizzaTopping2, pizzamodel.PizzaTopping3, pizzamodel.PizzaTopping4, pizzamodel.PizzaTopping5 };
            //remove blank entries from templist
            templist = templist.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            piz.toppings = templist;
            //create pizzastring
            piz.PizzaString = piz.showPizza();

            //find out what number of pizza this order is
            int pizzacounter = (int)HttpContext.Session.GetInt32("pizzacounter");
            //increment pizzacounter by 1
            pizzacounter = pizzacounter + 1;
            //set pizzacounter session variable to new pizzacounter
            HttpContext.Session.SetInt32("pizzacounter", pizzacounter);
            //note that we will always have pizzacounter - 1 pizzas



            //add pizza string to a session;
            HttpContext.Session.SetString($"pizzastring{pizzacounter}", piz.PizzaString);

            //find out how many pizzas we got
            //first i need to recreate all of our pizzaobjects and add them to tempOrder
            for(int i =0; i < pizzacounter; i++)
            {
                //intialize temppizzastring
                string temppizzastring = "";
                temppizzastring = HttpContext.Session.GetString($"pizzastring{i+1}");
                Pizza mypiz = new Pizza();
                mypiz = mypiz.recreatePizza(temppizzastring);
                tempOrder.addPizza(mypiz);

            }


            HttpContext.Session.SetInt32("pizzacount", tempOrder.getCount());
            ViewData["count"] = HttpContext.Session.GetInt32("pizzacount");
            //find out what our cost is at, in string form for some reason i can't explain
            //get current cost total
            string currentcoststring = HttpContext.Session.GetString("pizzacost");
            //convert current cost to double
            double currentcostdouble = Convert.ToDouble(currentcoststring);
            //add current double cost with our new cost double
            double nextcostdouble = currentcostdouble + tempOrder.gettotalpizzacost();
            //save new cost to session
            HttpContext.Session.SetString("pizzacost", nextcostdouble.ToString());
            ViewData["cost"] = HttpContext.Session.GetString("pizzacost");
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserCustom(Models.PizzaModel pizzamodel)
        {
            //create pizza
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

            //find out what number of pizza this order is
            int pizzacounter = (int)HttpContext.Session.GetInt32("pizzacounter");
            //increment pizzacounter by 1
            pizzacounter = pizzacounter + 1;
            //set pizzacounter session variable to new pizzacounter
            HttpContext.Session.SetInt32("pizzacounter", pizzacounter);
            //note that we will always have pizzacounter - 1 pizzas



            //add pizza string to a session;
            HttpContext.Session.SetString($"pizzastring{pizzacounter}", piz.PizzaString);

            //find out how many pizzas we got
            //first i need to recreate all of our pizzaobjects and add them to tempOrder
            for (int i = 0; i < pizzacounter; i++)
            {
                //intialize temppizzastring
                string temppizzastring = "";
                temppizzastring = HttpContext.Session.GetString($"pizzastring{i + 1}");
                Pizza mypiz = new Pizza();
                mypiz = mypiz.recreatePizza(temppizzastring);
                tempOrder.addPizza(mypiz);

            }


            HttpContext.Session.SetInt32("pizzacount", tempOrder.getCount());
            ViewData["count"] = HttpContext.Session.GetInt32("pizzacount");
            //find out what our cost is at, in string form for some reason i can't explain
            //get current cost total
            string currentcoststring = HttpContext.Session.GetString("pizzacost");
            //convert current cost to double
            double currentcostdouble = Convert.ToDouble(currentcoststring);
            //add current double cost with our new cost double
            double nextcostdouble = currentcostdouble + tempOrder.gettotalpizzacost();
            //save new cost to session
            HttpContext.Session.SetString("pizzacost", nextcostdouble.ToString());
            ViewData["cost"] = HttpContext.Session.GetString("pizzacost");
            return View();


        }


        //pushes the pizza order into the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserPreview(Models.OrderModel order)
        {
            //show what the stats are
            ViewData["count"] = HttpContext.Session.GetInt32("pizzacount");
            //find out what our cost is at, in string form for some reason i can't explain
            HttpContext.Session.GetString("pizzacost");
            ViewData["cost"] = HttpContext.Session.GetString("pizzacost");

            //attempt to push pizza to the database.
            //first create new pizza order
            PizzaOrder finalpizza = new PizzaOrder();

            //obtain value for pizzacounter
            int pizzacounter = (int)HttpContext.Session.GetInt32("pizzacounter");

            //loop through all my sessions that are storing my pizza objects
            //make pizza objects and add them to my order and pizzatable.
            for (int i = 0; i < pizzacounter; i++)
            {
                //intialize temppizzastring
                string temppizzastring = "";
                temppizzastring = HttpContext.Session.GetString($"pizzastring{i + 1}");
                Pizza mypiz = new Pizza();
                mypiz = mypiz.recreatePizza(temppizzastring);
                finalpizza.addPizza(mypiz);

            }

            //add current location to pizzaorder so it doesn't break my sql query
            finalpizza.LocationAddress = HttpContext.Session.GetString("location");

            //make a pizzauser cause its an input for my database add method.
            PizzaUser pizuser = new PizzaUser();
            pizuser.username = HttpContext.Session.GetString("username");

            bool didorderwork = false;

            if(PC.CheckOrderConditions(finalpizza.LocationAddress, pizuser.username))
            {
                didorderwork = PC.AddPizzaOrder(finalpizza, pizuser);
            }
            else
            {
                didorderwork = false;
            }
           

            if (didorderwork)
            {
                //finally try to add the thing to the database
                ViewData["isOrdervalid"] = "Order is valid";
                return RedirectToAction("login", "user", order);
            }
            else
            {
                ViewData["isOrdervalid"] = "Order is invalid";
                return View();
            }
        }

        //load userpreset without going through logic
        public IActionResult UserPreset()
        {
            ViewData["count"] = HttpContext.Session.GetInt32("pizzacount");
            ViewData["cost"] = HttpContext.Session.GetString("pizzacost");
            return View();
        }

        public IActionResult UserCustom()
        {
            ViewData["count"] = HttpContext.Session.GetInt32("pizzacount");
            ViewData["cost"] = HttpContext.Session.GetString("pizzacost");
            return View();
        }

        public IActionResult UserPreview()
        {
            ViewData["count"] = HttpContext.Session.GetInt32("pizzacount");
            //find out what our cost is at, in string form for some reason i can't explain
            HttpContext.Session.GetString("pizzacost");
            ViewData["cost"] = HttpContext.Session.GetString("pizzacost");
            //convert the above to numbers for comparison
            int pizcount = (int)HttpContext.Session.GetInt32("pizzacount");
            double pizcost = Convert.ToDouble(HttpContext.Session.GetString("pizzacost"));
            bool timecondition = PC.CheckOrderConditions(HttpContext.Session.GetString("location"), HttpContext.Session.GetString("username"));

            if (pizcount > 100 || pizcost > 5000.00 || timecondition == false)
            {
                ViewData["isOrdervalid"] = "Order is invalid";
            }
            else
            {
                ViewData["isOrdervalid"] = "Order is valid";
            }

          
            return View();
        }

        //lets admin pick which thing they wanna see
        public ActionResult AdminSelection(Models.LocationModel loc)
        {
            ViewData["adminlocation"] = HttpContext.Session.GetString("adminlocation");
            return View(loc);
        }





    }
}