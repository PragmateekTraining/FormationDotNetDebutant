using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class QuoteSample
    {
        public void Run()
        {
            decimal bid = 1.23m;
            decimal ask = 1.26m;

            Quote quote = new Quote
            {
                Bid = bid,
                Ask = ask
            };

            QuoteV2 quoteV2 = new QuoteV2
            {
                Bid = bid,
                Ask = ask
            };

            Console.WriteLine("Mid V1: {0}.", quote.Mid);
            Console.WriteLine("Mid V2: {0}.", quoteV2.Mid);
        }
    }
}
