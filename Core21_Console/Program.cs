using System;
using System.Collections.Generic;

namespace Core21_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Add("6");
            list.Add("7");
            
            foreach (var s in list)
            {
                var s2 = $"{s} - test";
            }
        }
    }
}