using System;

namespace Basics
{
    public class PrePostSample
    {
        public int PreIncrement(ref int n)
        {
            n = n + 1;
            return n;
        }

        public int PostIncrement(ref int n)
        {
            int oldValue = n;
            n = n + 1;
            return oldValue;
        }

        public void Run()
        {
            int n = 10;

            int m = PreIncrement(ref n);

            Console.WriteLine("After pre-increment: n={0} and m={1}.", n, m);


            n = 10;

            m = PostIncrement(ref n);

            Console.WriteLine("After post-increment: n={0} and m={1}.", n, m);
        }
    }
}
