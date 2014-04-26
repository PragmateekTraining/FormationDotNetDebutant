using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ShoppingCartItemSample
    {
        public void Run()
        {
            decimal price = 123;
            int quantity = 100;

            ShoppingCartItem item = new ShoppingCartItem
            {
                Price = price,
                Quantity = quantity
            };

            ShoppingCartItemV2 itemV2 = new ShoppingCartItemV2
            {
                Price = price,
                Quantity = quantity
            };

            Console.WriteLine("Total price V1: {0:0.00}.", item.TotalPrice);
            Console.WriteLine("Total price V2: {0:0.00}.", itemV2.TotalPrice);
        }
    }
}
