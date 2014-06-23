using System;

namespace CSVCleanup
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCSV = @"  Id;Customer;Date
# Our best customer
 1;Chuck Norris;31/12/2099 
 2;John Doe;10/10/2010 
 3;Sponge Bob;01/01/2001 
# EOF";

            string[] lines = inputCSV.Split(new[]{ Environment.NewLine }, StringSplitOptions.None);

            string outputCSV = "";
            for (int i = 0; i < lines.Length; ++i)
            {
                string line = lines[i];

                if (line.StartsWith("#")) continue;

                line = line.Trim();
                line = line.Replace(';', '\t');

                outputCSV += line + System.Environment.NewLine;
            }

            outputCSV = outputCSV.TrimEnd('\n').TrimEnd('\r');

            Console.WriteLine("{0}", outputCSV);
        }
    }
}
