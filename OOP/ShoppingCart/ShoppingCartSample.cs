using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ShoppingCartSample
    {
        public void Run()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Add("Apple");
            cart.Add("Apple");

            ShoppingCartItem apples = cart["Apple"];

            // cart["Apple"] = null;

            Console.WriteLine(apples.Quantity);
        }
    }
}
