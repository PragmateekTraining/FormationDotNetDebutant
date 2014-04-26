using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ShoppingCartItemV3
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

        public decimal Discount
        {
            get
            {
                return 0.9m;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return Price * Quantity * Discount;
            }
        }
    }
}
