using System;
using System.Collections.Generic;

namespace DataTypesAndVariables.Answers
{
    public class Loops
    {
        public static void Main(string[] args)
        {
            //Do While Loop

            //Write a program that uses a do while statement. Inside the loop, a kid is asking "are we there yet"
            //Then ask the user for input. The loop ends when we have arrived and then print to the console that "We're here!"
            string response;

            do
            {
                Console.WriteLine("Are we there yet?");
                response = Console.ReadLine();

            } while (!response.Equals("We have arrived", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("We're here!\n");

            //While loops

            //Write a program using a while loop that counts by 5's up to 100 starting at 5
            //Expected output: 5 10 15 20 25 30 etc
            int num = 5;

            Console.WriteLine("Counting by 5's up to 100");
            while (num <= 100)
            {
                Console.Write($"{num} ");
                num += 5;
            }
            Console.WriteLine();


            //For Loops

            //Write a program that uses a for loop to count down from 30 to 0, by 3's
            //Expected output:  30 27 24 21 18 etc

            Console.WriteLine("Counting down from 30 by 3's:");
            for (int i = 30; i >= 0; i -= 3)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            //Post and pre increment

            // Write a program that uses a for loop with a pre incrementing counter and stops at <= 10 and increases by 1 each time
            Console.WriteLine("Counting from 0 to 10 with post increment evaluation");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            //What is the final number printed?

            Console.WriteLine();

            Console.WriteLine("Counting from 0 to 10 with pre increment evaluation");
            // Write a program that uses a for loop with a post incrementing counter and stops at <= 10 and increases by 1 each time
            for (int i = 0; i <= 10; ++i)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            //What is the final number printed?


            //Foreach Loop

            Console.WriteLine("Printing the even numbers with a for each loop");
            List<int> numbers = new List<int> { 1, 3, 2, 4, 9, 20, 83, 88, 10, -2, -3 };
            //Use a foreach loop to go over this list of numbers and only print the even numbers, not the odd
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.Write($"{number} ");
                }
            }

            Console.ReadLine();
        }
    }
}