using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizzaboxdomain;

namespace PizzaWebsite.Controllers
{

    public class UserController : Controller
    {
        private readonly IPizzaRepository PC;
        public UserController(IPizzaRepository PC)
        {
            this.PC = PC;
        }
        

       /* Models.UserModel user;
        List<Models.UserModel> UserList = new List<Models.UserModel>();
        */
        // GET: User

        // GET: Contact/Details/5
      
        // GET: Contact/Create
        /*
        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Models.UserModel user)
        {
            bool temp = false;
            Pizzaboxdomain.PizzaUser pizUser = new PizzaUser();
            pizUser.username = user.username;
            pizUser.password = user.password;

            try
            {
                temp = PC.register(pizUser.username, pizUser.password);
                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }
        */


        public IActionResult Login()
        {
            return View();
        }

      

   

        public IActionResult AdminLogin()
        {
            return View();
        }
    }
        
}