using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaWebsite.Models;
using Pizzaboxdomain;
using Pizzaboxdata.Data;
using System.Net.Http;
using System.Net;
using System.Data;


namespace PizzaWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //controller for the Login Screen
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        

        

        public IActionResult UserHistory()
        {
            return View();
        }
      
        public IActionResult UserPreview()
        {
            return View();
        }

        
        //logic for admin page, it should only show if the user is an admin and is correctly logged in
       
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult UsersHistory()
        {
            return View();
        }
        public IActionResult CustomOrPreset()
        {
            return View();
        }
        public IActionResult UserPreset()
        {
            return View();
        }
        

    }
}
