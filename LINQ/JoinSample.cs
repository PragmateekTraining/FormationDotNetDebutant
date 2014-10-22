using OOP;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class JoinSample
    {
        public void Run()
        {
            IEnumerable<ShoppingCartItem> itemsLeft = Enumerable.Empty<ShoppingCartItem>();
            IEnumerable<ShoppingCartItem> itemsRight = Enumerable.Empty<ShoppingCartItem>();

            IEnumerable<ShoppingCartItem> join1 = itemsLeft.Join(itemsRight, item => item.Product, item => item.Product, (itemLeft, itemRight) => new ShoppingCartItem
            {
                Product = itemLeft.Product,
                Price = (itemLeft.Price + itemRight.Price) / 2,
                Quantity = itemLeft.Quantity + itemRight.Quantity
            });

            IEnumerable<ShoppingCartItem> join2 = from itemLeft in itemsLeft
                                                  join itemRight in itemsRight on itemLeft.Product equals itemRight.Product
                                                  select new ShoppingCartItem
                                                    {
                                                        Product = itemLeft.Product,
                                                        Price = (itemLeft.Price + itemRight.Price) / 2,
                                                        Quantity = itemLeft.Quantity + itemRight.Quantity
                                                    };
        }
    }
}
