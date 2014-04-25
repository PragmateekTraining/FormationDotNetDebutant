using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting
{
    class Program
    {
        static void Numbers()
        {
            Console.WriteLine("{0:0000}", 1);
            Console.WriteLine("{0:0000}", 12);
            Console.WriteLine("{0:0000}", 123);
            Console.WriteLine("{0:0000}", 1234);

            Console.WriteLine("{0:0.000}", 1);
            Console.WriteLine("{0:0.000}", 1.2);
            Console.WriteLine("{0:0.000}", 1.23);
            Console.WriteLine("{0:0.000}", 1.234);

            Console.WriteLine("{0:e2}", 1);
            Console.WriteLine("{0:e2}", 12);
            Console.WriteLine("{0:e2}", 123);
            Console.WriteLine("{0:e2}", 1234);

            Console.WriteLine("{0:e}", 1234.56);
        }

        static void DateTimes()
        {
            Console.WriteLine("{0:yyyy-MM-dd}", DateTime.Now);
            Console.WriteLine("{0:HH:mm:ss}", DateTime.Now);
        }

        static void Main(string[] args)
        {
            Numbers();
            DateTimes();

            Console.ReadLine();
        }
    }
}
