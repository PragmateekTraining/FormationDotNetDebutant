using System.Collections.Generic;

namespace OOP
{
    public class ShoppingCart
    {
        private Dictionary<string, ShoppingCartItem> items = new Dictionary<string, ShoppingCartItem>();

        public void Add(string product)
        {
            Add(product, 1);
        }

        public void Add(string product, int quantity)
        {
            if (!items.ContainsKey(product))
            {
                items[product] = new ShoppingCartItem { Product = product };
            }

            ShoppingCartItem item = items[product];

            item.Quantity += quantity;
        }

        public void Add(params string[] products)
        {
            foreach (string product in products)
            {
                Add(product);
            }
        }

        public bool TryGet(string product, out ShoppingCartItem item)
        {
            item = null;

            if (items.ContainsKey(product))
            {
                item = new ShoppingCartItem(items[product]);
                return true;
            }

            return false;
        }

        public ShoppingCartItem this[string product]
        {
            get
            {
                return items.ContainsKey(product) ? new ShoppingCartItem(items[product]) : null;
            }
        }
    }
}
