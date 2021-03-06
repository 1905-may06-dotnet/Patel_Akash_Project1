﻿using System;
using System.Collections.Generic;
using System.Linq;
using Pizzaboxdomain;

namespace Pizzaboxdata.Data
{
    public static class Mapper
    {
        //mapper for pizzaorder object to order table
        public static Pizzaboxdomain.PizzaOrder Map(OrderTable orderTable) => new Pizzaboxdomain.PizzaOrder
        {
            LocationAddress = orderTable.LocationFk,
            totalpizzacost = (double)orderTable.OrderTotalCost,
            OrderDatetime = (DateTime)orderTable.OrderDateTime,
            orderID = (int)orderTable.OrderIdPk,
            username = orderTable.UsernameFk
        };


        public static Pizzaboxdomain.Pizza Map(PizzaTable pizzaTable) => new Pizzaboxdomain.Pizza
        {
            quantity = (int)pizzaTable.PizzaCount,
            PizzaString = (string)pizzaTable.PizzaString
        };

        public static OrderTable Map(Pizzaboxdomain.PizzaOrder pizzaOrder) => new OrderTable
        {
            LocationFk = pizzaOrder.LocationAddress,
            OrderTotalCost = pizzaOrder.totalpizzacost,
            OrderDateTime = pizzaOrder.OrderDatetime,
            OrderIdPk = pizzaOrder.orderID,
            UsernameFk = pizzaOrder.username

        };

        public static PizzaTable Map(Pizzaboxdomain.Pizza pizza) => new PizzaTable
        {
            PizzaCount = pizza.quantity,
            PizzaString = pizza.PizzaString

        };
        public static Pizzaboxdomain.PizzaUser Map(UserTable usertable) => new Pizzaboxdomain.PizzaUser
        {
            password = usertable.Password,
            username = usertable.UsernamePk
        };

        public static UserTable Map(Pizzaboxdomain.PizzaUser user) => new UserTable
        {
            Password = user.password,
            UsernamePk = user.username
        };

        public static LocationTable Map(Pizzaboxdomain.PizzaLocations loc) => new LocationTable
        {
            PizzaCheese = loc.PizzaCheese,
            PizzaDough = loc.PizzaDough,
            PizzaSauce = loc.PizzaSauce,
            Mushrooms = loc.Mushrooms,
            Onions = loc.onions,
            Bellpepper = loc.bellpeppers,
            Jalapeno = loc.jalapeno,
            Spinache = loc.spinach

        };

        public static Pizzaboxdomain.PizzaLocations Map(LocationTable loc) => new Pizzaboxdomain.PizzaLocations
        {
            PizzaCheese = (int)loc.PizzaCheese,
            PizzaDough = (int)loc.PizzaDough,
            PizzaSauce = (int)loc.PizzaSauce,
            Mushrooms = (int)loc.Mushrooms,
            onions = (int)loc.Onions,
            bellpeppers = (int)loc.Bellpepper,
            jalapeno = (int)loc.Jalapeno,
            spinach = (int)loc.Spinache
        };



    }
}
