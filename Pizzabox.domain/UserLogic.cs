using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaboxdomain
{
    public class PizzaUser
    {

        //requirements      
        /*- should be able to view its order history <- this should be in data
       - should be able to only order from 1 location/day
       - should be able to only order 1 time within a 2 hour period
       - should be able to only order if an account exists*/

        //properties of a user;
       public DateTime lastOrder = new DateTime(2019, 5, 13, 13, 0, 15);
        public bool canorder = false;
        public string username = "";
        public string password = "";
       public bool isLoggedin = false;

        //method to check if user is admin
        public bool isAdmin()
        {
            if (username.Equals("admin"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //constructor, it asks the user to either register or log in.
        public PizzaUser CreateUser(string username, string password)
        {
            PizzaUser pizuser = new PizzaUser();
            pizuser.username = username;
            pizuser.password = password;
            return pizuser;
        }


        public void logout()
        {
            isLoggedin = false;
        }

    }
}






