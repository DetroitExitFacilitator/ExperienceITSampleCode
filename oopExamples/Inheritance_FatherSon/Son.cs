using System;

namespace Inheritance_FatherSon
{
    public class Son : Father
    {
        public string SonsLastName { get; set; }
        public Son()
        {
            FirstName = "Luke";
            SonsLastName = base.LastName;
        }

        public override void YellName()
        {
            Console.WriteLine($"My name is {FirstName} {SonsLastName} and I'm a {this.GetType().Name} and I inherited my dad jokes from my {this.GetType().BaseType.Name}!");
        }

        public override void TellJoke()
        {
            Console.WriteLine($"{FirstName}: When bald people wash their face, how high up do they go?");
        }

        public void StealDadJoke()
        {
            TellDadJoke();
            Console.WriteLine("I totally just thought of that joke on my own right now and didn't steal it from anyone else...");
        }

        public void FixR2D2()
        {
            Console.WriteLine("BleepBloopBleeeeeepBlooop");
        }
    }
}