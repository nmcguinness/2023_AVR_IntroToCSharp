using AVR.Core;
using AVR.Entities;
using System;
using System.Collections.Generic;

namespace AVR
{
    internal class Program
    {
        private string ID; //instance variable

        private static void Main(string[] args)
        {
            //instance of Program == somewhere in RAM there is a BOX with all instance variable
            Program myProg = new Program();
            //call the non-static (instance) methods
            myProg.Start();
        }

        //non-static method == instance method == can only call if we have instance
        public void Start()
        {
            //class, properties, enums
            DemoClassAndProperties();

            //list
            DemoList();

            //interface
            DemoInterface();

            //Demo Events - Player (OnWin, OnDie, OnRespawn)

            //stops console closing
            Console.ReadKey();
        }

        private void DemoList()
        {
            //version 1 of adding to a list
            List<Player> pList1 = new List<Player>();
            pList1.Add(new Player("a", 100, AbilityType.Intermediate, 1000));
            pList1.Add(new Player("b", 50, AbilityType.God, 100000));

            for (int i = 0; i < pList1.Count; i++)
                Console.WriteLine(pList1[i]);

            Console.WriteLine("\n-----------------");

            foreach (Player p in pList1)
                Console.WriteLine(p);

            //version 2 of adding to a list - simple and faster
            List<Player> pList2 = new List<Player>
            {
                new Player("axe", 60, AbilityType.Beginner, 1000),
                new Player("brutus", 10, AbilityType.God, 100000)
            };

            Console.WriteLine("\npList2 before upgrades....\n");

            foreach (Player p in pList2)
                Console.WriteLine(p);

            //make the upgraders (health, type) here
            IUpgradeGameObject healthUpgrader = new UpgradePlayerHealth();
            IUpgradeGameObject typeUpgrader = new UpgradePlayerType();

            List<IUpgradeGameObject> listOfUpgrades = new List<IUpgradeGameObject>
            {
                new UpgradePlayerHealth(),
                new UpgradePlayerType()
            };

            foreach (Player p in pList2)
            {
                foreach (IUpgradeGameObject upgrader in listOfUpgrades)
                {
                    upgrader.Upgrade(p);
                }
                //healthUpgrader.Upgrade(p);
                //typeUpgrader.Upgrade(p);
                //  UpgradeHealth(p);
                //  UpgradeType(p);
            }

            Console.WriteLine("\npList2 after upgrades....\n");

            foreach (Player p in pList2)
                Console.WriteLine(p);
        }

        private void DemoInterface()
        {
            //   throw new NotImplementedException();
        }

        public void DemoClassAndProperties()
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
        }

        //public void UpgradeHealth(Player p)
        //{
        //    //if low, then upgrade
        //    if (p.Health < 100)
        //        p.Health += 100;
        //}

        //public void UpgradeType(Player p)
        //{
        //    int typeAsInt = (int)p.Type;

        //    if (typeAsInt >= 1 && typeAsInt <= 3) //beginner -> expert
        //    {
        //        typeAsInt++; //promotion
        //        p.Type = (AbilityType)typeAsInt; //converting a number back into an enum
        //    }
        //}
    }
}