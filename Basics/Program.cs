using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        class A
        {
            public static void F() { }
        }

        class B : A
        {
        }

        static void Main(string[] args)
        {
            B.F();

            new PrePostSample().Run();
        }
    }
}
