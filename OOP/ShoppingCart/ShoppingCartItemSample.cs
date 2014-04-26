using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ShoppingCartItemSample
    {
        const decimal price = 123;
        const int quantity = 100;

        private void Simple()
        {
            ShoppingCartItemV1 item = new ShoppingCartItemV1();
            item.Price = price;
            item.Quantity = quantity;

            ShoppingCartItemV2 itemV2 = new ShoppingCartItemV2();
            itemV2.Price = price;
            itemV2.Quantity = quantity;

            ShoppingCartItemV3 itemV3 = new ShoppingCartItemV3();
            itemV3.Price = price;
            itemV3.Quantity = quantity;

            Console.WriteLine("Total price V1: {0:0.00}.", item.TotalPrice);
            Console.WriteLine("Total price V2: {0:0.00}.", itemV2.TotalPrice);
            Console.WriteLine("Total price V3: {0:0.00}.", itemV3.TotalPrice);
        }

        private void WithObjectInitializers()
        {
            ShoppingCartItemV1 item = new ShoppingCartItemV1
            {
                Price = price,
                Quantity = quantity
            };

            ShoppingCartItemV2 itemV2 = new ShoppingCartItemV2
            {
                Price = price,
                Quantity = quantity
            };

            ShoppingCartItemV3 itemV3 = new ShoppingCartItemV3
            {
                Price = price,
                Quantity = quantity
            };

            Console.WriteLine("Total price V1: {0:0.00}.", item.TotalPrice);
            Console.WriteLine("Total price V2: {0:0.00}.", itemV2.TotalPrice);
            Console.WriteLine("Total price V3: {0:0.00}.", itemV3.TotalPrice);
        }

        public void Run()
        {
            Simple();

            Console.WriteLine("==========");

            WithObjectInitializers();
        }
    }
}
