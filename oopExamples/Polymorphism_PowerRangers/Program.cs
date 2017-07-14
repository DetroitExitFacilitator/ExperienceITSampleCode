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

            foreach (var ranger in rangers)
            {
                ranger.YellName();
            }

            Console.WriteLine();

            Console.WriteLine("Aww yeah, you know what time it is? It's Morphin Time!");

            Console.WriteLine();

            foreach (var ranger in rangers)
            {
                ranger.Morph();
            }

            Console.ReadLine();
        }
    }
}
