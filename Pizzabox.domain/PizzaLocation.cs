using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pizzaboxdomain
{
    public class PizzaLocations
    {
        //contains a list of all current locations
        List<string> locations = new List<string>();
        public string current = "";

        public PizzaLocations()
        {
            locations.Add("1111 west pine street");
            locations.Add("7373 east shoulder avenue");
            locations.Add("8787 harbor road");
        }

        public void showLocations()
        {
            int count = 1; //counter variable to number out locations
            foreach (string address in locations)
            {
                //print each location in the list
                Console.WriteLine($"Address {count}: {address}");
                count++;
            }
        }



    }
}
