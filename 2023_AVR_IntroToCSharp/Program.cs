using AVR.Core;
using System;

namespace AVR
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Network n = new Network();
            //  AVR.Core.Network n = new AVR.Core.Network();
        }
    }
}