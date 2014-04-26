﻿using System;
using System.Collections.Generic;

namespace CollectionsInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> greetingsMap = new Dictionary<string, string>
            {
                { "English",    "Hello" },
                { "French",     "Bonjour" },
                { "German",     "Guten tag" },
                { "Japanese",   "Konnichi wa" },
                { "Spanish",    "Buenos dias" }
            };

            string userInput = null;
            do
            {
                Console.Write("Your language? ");

                userInput = Console.ReadLine();

                if (userInput != "")
                {
                    if (!greetingsMap.ContainsKey(userInput))
                    {
                        Console.WriteLine("Language '{0}' is not handled!", userInput);
                        continue;
                    }

                    string greeting = greetingsMap[userInput];

                    Console.WriteLine("{0} {1}!", greeting, Environment.UserName);
                }
            }
            while (userInput != "");
        }
    }
}
