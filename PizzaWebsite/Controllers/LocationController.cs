using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace PizzaWebsite.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //this is what happens when you click select location on user location screen
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserLocation(Models.LocationModel loc)
        {
            HttpContext.Session.SetString("location", loc.Location);

            return RedirectToAction("CustomOrPreset", "Order", loc);
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLocation(Models.LocationModel loc)
        {
            Pizzaboxdomain.PizzaLocations pizLoc = new Pizzaboxdomain.PizzaLocations();
            HttpContext.Session.SetString("adminlocation", loc.Location);
            return RedirectToAction("AdminSelection", "Order", loc);

        }

        


        public ActionResult AdminLocation()
        {

            return View();
        }

        //this is what is shown when userlocation first loads up
        public IActionResult UserLocation()
        {
            
            ViewData["username"] = HttpContext.Session.GetString("username");
            return View();
        }

       
    }
}