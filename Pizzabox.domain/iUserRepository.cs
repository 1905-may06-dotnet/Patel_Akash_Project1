﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaboxdomain
{
    public interface IUserRepository
    {
        /// <summary>
        /// return usernames as a list of strings.
        /// </summary>
        bool register(string username, string password);
        bool login(string username, string password);

        List<PizzaOrder> searchbyUsername(string username);
    }
}
