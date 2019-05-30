using System;
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
            OrderDateTime = pizzaOrder.OrderDatetime

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

        

    }
}
