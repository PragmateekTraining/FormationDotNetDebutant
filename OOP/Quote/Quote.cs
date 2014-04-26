using System;

namespace OOP
{
    public class Quote
    {
        public string Ticker { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
        public decimal Mid
        {
            get
            {
                return (Bid + Ask) / 2;
            }
        }
    }

    public class QuoteV2
    {
        private decimal tick = 0.01m;

        public string Ticker { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
        public decimal Mid
        {
            get
            {
                return Math.Floor((Bid + Ask) / 2 / tick) * tick;
            }
        }
    }
}
