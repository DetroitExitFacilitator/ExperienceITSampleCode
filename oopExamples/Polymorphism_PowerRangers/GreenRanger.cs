using System;

namespace Polymorphism_PowerRangers
{
    public class GreenRanger : IRanger
    {
        public string RangerName { get; set; }
        public string Zord { get; set; }

        public GreenRanger(string name)
        {
            RangerName = name;
            Zord = "Dragon";
        }

        public void YellName()
        {
            Console.WriteLine($"{RangerName}, let's go!");
        }

        public void Morph()
        {
            Console.WriteLine($"{RangerName}, morph into...{Zord}!");
        }
    }
}