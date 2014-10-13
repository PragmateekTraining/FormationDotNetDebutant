using System;

namespace LogicalOperators
{
    class Program
    {
        static bool True1()
        {
            Console.WriteLine("True1()");

            return true;
        }

        static bool False()
        {
            Console.WriteLine("False()");

            return false;
        }

        static bool True2()
        {
            Console.WriteLine("True2()");

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Using & operators ===");

            if (True1() & False() & True2()) ;

            Console.WriteLine("=== Using && operators ===");

            if (True1() && False() && True2()) ;
        }
    }
}
