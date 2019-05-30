using System;
using System.Collections.Generic;
using Pizzaboxdomain;


namespace Pizzaboxdomain
{
    class Program
    {
        static void Main(string[] args)
        {
      
            
  
        }

    }
    public class Pizza
    {
        public string size = "";
        public List<string> toppingsAvailable = new List<string>
        {
            "mushrooms", "onions", "bellpepper", "spinache", "jalepeno"
        };
        public enum pizzaSize { s = 1, m, l };
        public List<string> toppings = new List<string>();
        public int numToppings = 0;
        public string crust = "";
        public int quantity = 0;
        //string that holds all the information about all objects in the pizza, will probably need to add a method here to define it
        public string PizzaString = "";
          
        public double GetPizzaCost(Pizza Piz)
        {
            //inititalize variables used to compute cost
            double sizecost = 0.0;
            double crustcost = 0.0;
            double toppingcost = 0.0;

            //determine cost due to pizza size
            if (Piz.size.Equals("s"))
            {
                sizecost = 2.5;
            }
            else if (Piz.size.Equals("m"))
            {
                sizecost = 3.5;
            }
            else if (Piz.size.Equals("l"))
            {
                sizecost = 48.75;
            }

            //determine cost due to pizza curst

            if (Piz.crust.Equals("s"))
            {
                crustcost = 0.0;
            }
            else if (Piz.crust.Equals("l"))
            {
                crustcost = 1.0;
            }

            toppingcost = numToppings * 0.25;
            //multiply by quantity at the end
            return (sizecost + crustcost + toppingcost)*Piz.quantity;
        }

        public string showPizza()
        {
            string constring = ""; //string to contain list of all the toppings customer has ordered
            foreach (string str in toppings)
            {
                constring += str + ", ";
            }

            //return full description of the pizza, this is also what will be stored in SQL.
            return($"size: {size}, crust: {crust}, toppings: {constring} and quantity: {quantity}");
        }


        
       
       
        //string that holds all the information about all objects in the pizza, will probably need to add a method here to define it
        public Pizza OrderPizza(string size, string crust, List<string> toppings, int quantity)
        {
            Pizza piz = new Pizza();
            piz.size = size;
            piz.crust = crust;
            piz.toppings = toppings;
            piz.quantity = quantity;
            piz.numToppings = toppings.Count;
            piz.PizzaString = piz.showPizza();
            return piz;
        }

        

        //this function allows the user to order more than 1 of the pizza they just bought
       

        

        

      



        }
    }

