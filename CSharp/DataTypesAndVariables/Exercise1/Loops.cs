using System.Collections.Generic;
using System;

namespace DataTypesAndVariables.Exercise1
{
    public class Loops
    {
        public static void Main(string[] args)
        {
            //Do While Loop

            //Write a program that uses a do while statement. Inside the loop, a kid is asking "are we there yet"
            //Then ask the user for input. The loop ends when we have arrived and then print to the console that "We're here!"

            //While loops

            //Write a program using a while loop that counts by 5's up to 100 starting at 5
            //Expected output: 5 10 15 20 25 30 etc

            //Write a program that uses a for loop to count down from 30 to 0, by 3's
            //Expected output:  30 27 24 21 18 etc

            //For Loops

            //Write a program that uses a for loop to count down from 30 to 0, by 3's
            //Expected output:  30 27 24 21 18 etc

            //Post and pre increment

            //write a program that uses a for loop with a pre incrementing counter and stops at <= 10 and increases by 1 each time
            //What is the final number printed?

            //write a program that uses a for loop with a post incrementing counter and stops at <= 10 and increases by 1 each time
            //What is the final number printed?

            //Foreach Loop

            List<int> numbers = new List<int> { 1, 3, 2, 4, 9, 20, 83, 88, 10, -2, -3 };
            //Use a foreach loop to go over this list of numbers and only print the even numbers, not the odd
            Console.ReadKey();
        }
    }
}
