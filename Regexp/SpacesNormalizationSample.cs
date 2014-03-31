using System;
using System.Text.RegularExpressions;

namespace Regexp
{
    public class SpacesNormalizationSample
    {
        public void Run()
        {
            while (true)
            {
                Console.Write("Your input: ");

                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                string output = Regex.Replace(input, "[ ]+", " ", RegexOptions.Compiled).Trim();

                Console.WriteLine("'{0}' -> '{1}'", input, output);
            }
        }
    }
}
