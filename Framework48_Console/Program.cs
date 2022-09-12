using System;
using Dll;

namespace Framework48_Console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dll1 = new Dll1();
            var somethingFromDll = dll1.GetSomethingFromDll();
            
            
            Console.WriteLine(somethingFromDll);

            int t = 1;
            while (t <100)
            {
                var s = t;
                t++;
            }
        }
    }
}