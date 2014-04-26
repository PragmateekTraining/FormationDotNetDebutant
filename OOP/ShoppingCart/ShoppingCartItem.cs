using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ShoppingCartItem
    {
        public string Product { get; set; }
        public decimal Price { get; set; }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be a positive integer!");
                }

                quantity = value;
            }
        }

        private decimal discount;
        public decimal Discount
        {
            get
            {
                return discount;
            }
            private set
            {
                discount = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return Price * Quantity * Discount;
            }
        }

        public ShoppingCartItem()
        {
        }

        public ShoppingCartItem(ShoppingCartItem item)
        {
            Product = item.Product;
            Price = item.Price;
            Quantity = item.Quantity;
            Discount = item.Discount;
        }
    }
}
