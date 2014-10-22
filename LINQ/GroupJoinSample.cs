using OOP;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class JoinSample
    {
        public void Run()
        {
            IEnumerable<string> categories = Enumerable.Empty<string>();
            IEnumerable<ShoppingCartItem> items = Enumerable.Empty<ShoppingCartItem>();

            var join1 = categories.GroupJoin(items, category => category, item => item.Category, (category, itemsGroup) => new
                        {
                            Category = category,
                            Items = itemsGroup
                        });

            var join2 = from category in categories
                        join item in items on category equals item.Category into itemsGroup
                        select new 
                        {
                            Category = category,
                            Items = itemsGroup
                        };
        }
    }
}
