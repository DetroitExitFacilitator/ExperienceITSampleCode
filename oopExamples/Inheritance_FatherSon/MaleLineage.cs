using System;

namespace Inheritance_FatherSon
{
    public abstract class MaleLineage
    {
        public abstract void YellName();
        public abstract void TellJoke();
        public virtual void TellDadJoke() {
            Console.WriteLine("I do nothing right now.");
        }
    }
}