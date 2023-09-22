using AVR.Core;
using AVR.Entities;
using System;

namespace AVR
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Network n = new Network();
            //  AVR.Core.Network n = new AVR.Core.Network();

            Player p1 = new Player("max", 95, AbilityType.Intermediate, 50);
            //use a setter
            p1.Health = 25; //by passing a value I use the setter
                            // p1.Type = "intermediate";
                            //use a getter

            AbilityType theType = p1.Type;
            Console.WriteLine((int)theType);

            // Console.WriteLine(p1);
            Console.WriteLine(p1.ToString());

            Console.ReadKey();
        }
    }
}