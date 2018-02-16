using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine($"Hello World!");
            var names = new List<string> { "Guillermo", "Luke", "Tyler" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();
            //can add or remove names to a list using below method
            names.Add("Stephanie");
            names.Add("Joe W");
            names.Remove("Tyler");
            //Example of lopping through a List below
            foreach (var name in names)
            {
                Console.WriteLine($"My name is {name.ToUpper()}");
            }
            Console.WriteLine($"My real name is {names[0]}");
        }
    }
}