using System;

namespace Decimals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (float x = 0; x != 10.0; x += 0.2)
            {
                Console.Write(x);
                Console.ReadLine();
            }*/

            for (float x = 0; x != 10.0; x += 0.2f)
            {
                Console.Write(DoubleConverter.ToExactString(x));
                Console.ReadLine();
            }
        }
    }
}
