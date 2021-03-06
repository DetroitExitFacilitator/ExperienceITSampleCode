﻿using System;

namespace Inheritance_FatherSon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // We start by creating an instance of the Father and Son class, 
            // We can't create an instance of MaleLineage because it is an abstract class
            var father = new Father();
            var son = new Son();

            Console.WriteLine("Welcome to comedy night at the Inheritance Club, please give a warm welcome for our entertainers this evening...\n");

            // Here we invoke the method YellName which is declared in MaleLineage and then overriden in the inheriting classes
            father.YellName();
            son.YellName();

            Console.WriteLine($"\nWe'll let the old man have the stage first, take it away {father.FirstName}\n");

            // Now the father 
            father.TellJoke();
            father.TellDadJoke();
            father.FixC3P0();

            Console.WriteLine($"That's a tough act to follow, {son.FirstName}, but go ahead and show us what you got\n");


            son.TellJoke();
            son.FixR2D2();
            son.FixC3P0();
            
            // The method the Son created to "steal credit for" the dad joke
            son.StealDadJoke();
            // The method TellDadJoke is still available to this instance of the son, even without having to be wrapped inside another method
            son.TellDadJoke();

            Console.ReadLine();
        }
    }
}
