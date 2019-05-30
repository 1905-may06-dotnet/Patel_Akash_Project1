using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaWebsite.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserLocation()
        {
            return View();
        }
        public IActionResult AdminLocation()
        {

            return View();
        }
    }
}