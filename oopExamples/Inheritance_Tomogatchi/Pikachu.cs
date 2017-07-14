using System;

namespace Inheritance_Tomogatchi
{
    public class Pikachu : GameObject
    {
        public int Level { get; set; }

        public Pikachu(string name, int level) : base(name)
        {
            Level = level;
        }

        public override void DoSomething()
        {
            Console.WriteLine($"{ObjectName} Lv({Level}): Pika Pika!");
        }
    }
}