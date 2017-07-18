using System;
using System.Collections.Generic;

namespace Polymorphism_PowerRangers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ItsMorphinTime();
        }

        public static void ItsMorphinTime()
        {
            //Here we create a List of IRanger objects that allows us to create Green/Red/Pink Ranger instances
            //because they all implement the same interface. For polymorphism, we can also use a class to operate with
            //polymorphically. It doesn't have to be an interface
            List<IRanger> rangers = new List<IRanger>
            {
                new GreenRanger("Green Ranger"),
                new RedRanger("Red Ranger"),
                new PinkRanger("Pink Ranger")
            };

            Console.WriteLine("Go go, Power Rangers...");

            Console.WriteLine();

            Console.WriteLine("Oh no, gang. It's Rita Repulsa and Goldar. Who's with me to help save the town?");

            Console.WriteLine();

            //Now that we want to operate on the rangers polymorphically to YellName's,
            //we can do that because they are all using the same interface that defines YellName is required
            foreach (var ranger in rangers)
            {
                ranger.YellName();
            }

            Console.WriteLine();

            Console.WriteLine("Aww yeah, you know what time it is? It's Morphin Time!");

            Console.WriteLine();


            //Same thing here, because IRanger defines that Morph is part of the contract, we can
            //loop over all the Rangers to invoke their Morph method
            foreach (var ranger in rangers)
            {
                ranger.Morph();
            }

            Console.ReadLine();
        }
    }
}
