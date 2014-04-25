using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = File.ReadAllText("War_and_peace.txt").Split(' ');

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            string textWithoutSpaces1 = "";

            int max = Math.Min(tokens.Length, 50000);

            for (int i = 0; i < max; ++i)
            {
                textWithoutSpaces1 += tokens[i];
            }

            stopwatch.Stop();

            long withStringsDuration = stopwatch.ElapsedMilliseconds;

            stopwatch.Restart();

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < max; ++i)
            {
                stringBuilder.Append(tokens[i]);
            }

            string textWithoutSpaces2 = stringBuilder.ToString();

            long withStringBuilderDuration = stopwatch.ElapsedMilliseconds;

            if (textWithoutSpaces2 != textWithoutSpaces1)
            {
                throw new Exception("Resulting texts differ!");
            }

            Console.WriteLine("{0}ms vs {1}ms (x{2:0.00}).", withStringBuilderDuration, withStringsDuration, 100.0 * withStringsDuration / withStringBuilderDuration);

            Console.ReadLine();
        }
    }
}
