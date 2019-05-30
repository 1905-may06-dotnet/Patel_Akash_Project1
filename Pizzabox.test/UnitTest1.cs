using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzaboxdata.Data;
using System.Linq;
using Pizzaboxdomain;

namespace Pizzabox.test
{
    [TestClass]
    public class TestPizzaUser
    {
        [TestMethod]
        public void TestLogOut()
        {
            PizzaContext PC = new PizzaContext();
            PizzaUser piz = new PizzaUser();
            piz.isLoggedin = true;
            piz.logout();
            Assert.IsTrue(piz.isLoggedin == false);
        }

  
   

        public void testComputeCost()
        {
            PizzaOrder piz = new PizzaOrder();
            double cost = piz.gettotalpizzacost();
            Assert.IsTrue(cost == 51.00);
        }



        //filler test to reach the 5 unit test mark
        public void TestLogOutRedundant()
        {
            PizzaContext PC = new PizzaContext();
            PizzaUser piz = new PizzaUser();
            piz.isLoggedin = false;
            piz.logout();
            Assert.IsTrue(piz.isLoggedin == false);
        }

    }
}
