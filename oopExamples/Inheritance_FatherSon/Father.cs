using System;

namespace Inheritance_FatherSon
{
    public class Father : MaleLineage
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Father()
        {
            FirstName = "Anakin";
            LastName = "Skywalker";
        }

        public override void YellName()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and I'm a {this.GetType().Name}!");
        }

        public override void TellJoke()
        {
            Console.WriteLine($"{FirstName}: Do you think the ocean is salty because no one waves back?");
        }

        public sealed override void TellDadJoke()
        {
            Console.WriteLine($"{FirstName}: Why do chicken coops only have two doors?\nBecause if they had four, they would be chicken sedans!");
        }

        public void FixC3P0()
        {
            Console.WriteLine("Hello I am C3PO and I am fixed");
        }
    }
}