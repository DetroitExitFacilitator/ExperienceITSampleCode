using System;

namespace Polymorphism_PowerRangers
{
    public class RedRanger : IRanger
    {
        public string RangerName { get; set; }
        public string Zord { get; set; }

        public RedRanger(string name)
        {
            RangerName = name;
            Zord = "Tyrannosaurus Rex";
        }

        public void YellName()
        {
            Console.WriteLine($"{RangerName}, alright!");
        }

        public void Morph()
        {
            Console.WriteLine($"{RangerName}, morph into...{Zord}!");
        }
    }
}