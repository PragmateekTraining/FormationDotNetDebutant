﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ShoppingCartItemV2
    {
        private string product;
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

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
