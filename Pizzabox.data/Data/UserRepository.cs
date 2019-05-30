using Microsoft.EntityFrameworkCore;
using Pizzaboxdomain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaboxdata.Data
{
    /// <summary>
    /// A repository managing data access for restaurant objects and their review members.
    /// </summary>
    /// <remarks>
    /// This class ought to have better exception handling and logging.
    /// </remarks>
    public class UserRepository: IUserRepository
    {
        PizzaContext PC = new PizzaContext();


        //this method will need to be changed in order to make it html compatible to show the history
        public void showHistory(string username)
        {
            int i = 0;
            var x = PC.OrderTable.Where<OrderTable>(u => u.UsernameFk.Equals(username)).ToList();
            if (x == null)
            {
                //this means that there is no history to show
            }
            foreach (var obj in x)
            {

                obj.displayOrderDetails();
                //x[0] contains the orderID primary key, so im searching the pizza table for entries that match the
                //users order id
                var y = PC.PizzaTable.Where<PizzaTable>(u => u.OrderIdFk.Equals(x[i].OrderIdPk));

                foreach (var obj2 in y)
                {
                    obj2.displayPizzaDetails();

                }
                i += 1;
            }

        }

        //login a new user
        public bool login(string username, string password)
        {

            //check to see that the username matches an existing username in database
            UserTable x = PC.UserTable.Where<UserTable>(u => u.UsernamePk == username).FirstOrDefault<UserTable>();

            if (x == null)
            {
                //prompt user their username is not existant
                return false;

                //put some way to go back to first prompt where it asks for register or login
            }
            else
            {
                
                if (x.Password.Equals(password))
                {
                    return true;
                }
                else
                {
                    //tell user that they had a bad password
                    return false;

                    //put some way to go back to first prompt
                }

            }

        }



        public bool register(string username, string password)
        {
                //ensure that the username is not taken in the database
                //username cannot be the same as the password
                //check to see if the username matches an existing username in database
                UserTable x = PC.UserTable.Where<UserTable>(u => u.UsernamePk == username).FirstOrDefault<UserTable>();
                if (x == null)
                {
                    
                    if (username.Equals(password))
                    {
                    return false;
                    }
                    else
                    {
                    //step 2 write the user information into the database
                    PC.UserTable.Add(new UserTable() { UsernamePk = username, Password = password });
                    PC.SaveChanges();
                    return true;
                    }

                }
                else
                {
                //username is already in database
                return false;
                }
           
            
        }


    }

}
