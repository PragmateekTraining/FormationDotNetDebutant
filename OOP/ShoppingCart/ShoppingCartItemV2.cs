using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ShoppingCartItemV2
    {
        public string Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
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
