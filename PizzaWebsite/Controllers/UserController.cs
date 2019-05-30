using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizzaboxdomain;


namespace PizzaWebsite.Controllers
{

    public class UserController : Controller
    {
        private readonly IUserRepository PC;
        string username;

        //intialize context
        public UserController(IUserRepository PC)
        {
            this.PC = PC;
        }

       
        

       Models.UserModel user;
        List<Models.UserModel> UserList = new List<Models.UserModel>();
        
        // GET: User

        // GET: Contact/Details/5
      
        // GET: Contact/Create
        
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
                if (temp)
                { 
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.Message = "Your username is already taken or user password is the same as your username";
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.UserModel user)
        {
            bool temp = false;
            Pizzaboxdomain.PizzaUser pizUser = new PizzaUser();
            pizUser.username = user.username;
            pizUser.password = user.password;
            HttpContext.Session.SetString("username", pizUser.username);
            ViewData["username"] = pizUser.username;
            try
            {
                temp = PC.login(pizUser.username, pizUser.password);
                if (temp)
                {
                    ViewBag.Message = pizUser.username;
                    return RedirectToAction("UserOption");
                    
                }
                else
                {
                    ViewBag.Message = "Your password is incorrect or your username does not exist";
                    return View();
                }
            }
            catch
            {
                return View();
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(Models.UserModel user)
        {
            bool temp = false;
            Pizzaboxdomain.PizzaUser pizUser = new PizzaUser();
            pizUser.username = user.username;
            pizUser.password = user.password;

            try
            {
                temp = PC.login(pizUser.username, pizUser.password);
                if (temp && pizUser.username.Equals("admin"))
                {
                    
                    return RedirectToAction("AdminLocation","Location");

                }
                else
                {
                    ViewBag.Message = "Your credentials are incorrect";
                    return View();
                }
            }
            catch
            {
                return View();
            }

        }

        public IActionResult UserHistory()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        
        
        
        //this is what loads useroption when the view first shows up
        public IActionResult UserOption()
        {
            ViewData["username"] = HttpContext.Session.GetString("username");
            return View();
        }
      

        public IActionResult AdminLogin()
        {
            return View();
        }

     




    }
        
}