using System;

namespace Inheritance_Tomogatchi
{
    public class Tomogatchi : GameObject
    {
        public int Age { get; private set; }

        public Tomogatchi(string name, int age) : base(name)
        {
            Age = age;
        }

        public override void DoSomething()
        {
            Console.WriteLine($"Hi, my name is {ObjectName} and I am {Age} hours old.");
        }
    }
}