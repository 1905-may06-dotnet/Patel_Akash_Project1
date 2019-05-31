using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pizzaboxdomain
{
   public class PizzaOrder:Pizza
    {
       public string LocationAddress = "";
       public double totalpizzacost = 0.0;
       public List<Pizza> pizzalist = new List<Pizza>();
       public bool isValidOrder = true;
       public DateTime OrderDatetime;

        //this function gets us the cost for our order
        public double gettotalpizzacost()
        {
            //intialize cost to zero
            double cost = 0.0;
            //intialize for loop index to 0
            int i = 0;
            //loop through all the pizzas and calculate their cost individually
            foreach (var item in pizzalist)
            {
                cost =+ GetPizzaCost(item);
            }

            return cost;
        }

        //add pizza to order
        public void addPizza(Pizza piz)
        {
            pizzalist.Add(piz);
        }

        //main method used to order a pizza
        //will need to modify this
        public PizzaOrder CreateOrder()
        {
            PizzaOrder pizorder = new PizzaOrder();
            return pizorder;
        }

        //method used to remove a pizza from order
        public void removePizza(int index)
        {
            try
            {
                pizzalist.RemoveAt(index);
            }
            catch(IndexOutOfRangeException e)
            {
                throw e;
            }
            
        }

        //need SQL to implement this
        public void viewOrder()
        {
            Console.WriteLine("this method has not been implemented");
        }

        public int getCount()
        {
            int count = 0;
            foreach(var item in pizzalist)
            {
                count += item.quantity;
            }
            return count;
        }

        public bool checkCount()
        {
            if(getCount()>100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkCost()
        {
            if(gettotalpizzacost()>5000.00)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


     
        public PizzaOrder OrderPizza(string location, double cost, List<Pizza> pizlist)
        {
            PizzaOrder PizOrder = new PizzaOrder();

            PizOrder.LocationAddress = location;
            PizOrder.pizzalist = pizlist;
            PizOrder.totalpizzacost = this.gettotalpizzacost();
            PizOrder.OrderDatetime = DateTime.Now;
            PizOrder.isValidOrder = (this.checkCost() & this.checkCount());

            return PizOrder;
        }


        

        

    }


}
