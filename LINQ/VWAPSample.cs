using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class TradeLine
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class VWAPSample
    {
        public void Run()
        {
            TradeLine[] lines =
            {

            };

            decimal VWAP = lines.Aggregate(0m, (sumProduct, line) => sumProduct + line.Price * line.Quantity) / lines.Sum(line => line.Quantity);

            Console.WriteLine("VWAP: {0}.", VWAP);
        }
    }
}
