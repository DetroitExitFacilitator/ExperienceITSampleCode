using System;

namespace Inheritance_Tomogatchi.Answer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PlayGame();
        }

        public static void PlayGame()
        {
            var gameObject = new GameObject("Emptyness");
            var pikachu = new Pikachu("PikaPoo", 12);
            var tomogatchi = new Tomogatchi("TickleMonster", 3);

            Console.WriteLine("Calling GameObject.DoSomething()");
            gameObject.DoSomething();
            Console.WriteLine("Nothing happened because nothing is defined in GameObject's DoSomething() method.");

            Console.WriteLine();

            Console.WriteLine("Calling Pikachu.DoSomething()");
            pikachu.DoSomething();
            Console.WriteLine("It was super effective.");

            Console.WriteLine();

            Console.WriteLine("Calling Tomogatchi.DoSomething()");
            tomogatchi.DoSomething();
            Console.WriteLine("Awww, you're so cute, TickleMonster!");

            Console.ReadLine();
        }
    }
}
