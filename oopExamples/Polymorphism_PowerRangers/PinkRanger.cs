using System;

namespace Polymorphism_PowerRangers
{
    public class PinkRanger : IRanger
    {
        public string RangerName { get; set; }
        public string Zord { get; set; }

        public PinkRanger(string name)
        {
            RangerName = name;
            Zord = "Pterodactyl";
        }

        public void YellName()
        {
            Console.WriteLine($"{RangerName}, ready!");
        }

        public void Morph()
        {
            Console.WriteLine($"{RangerName}, morph into...{Zord}!");
        }
    }
}