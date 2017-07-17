using System;
using System.Collections.Generic;

namespace DataTypesAndVariables.Answers
{
    public class Collections
    {
        public static void Main(string[] args)
        {
            //array
            //write a program that creates an array of integers called "odds" with a size of 5 elements
            int[] odds = new int[5];
            //Then create a loop that will add the odd numbers between 0 and 10 to the array
            int nextOddSlot = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 != 0)
                {
                    odds[nextOddSlot] = i;
                    nextOddSlot += 1;
                }
                    
            }

            //again create a program that creates an integer array called "evens" with a size of 5 elements
            int[] evens = new int[5];
            //this time create a loop that will add the even numbers between 0 and 20 to the array
            int nextEvenSlot = 0;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    evens[nextEvenSlot] = i;
                    nextEvenSlot += 1;
                }
            }

            //Finally, for arrays, create a program that will sort this array of numbers from highest to lowest
            int[] numbers = new int[] { 1, 3, 2, 4, 9, 20, 83, 88, 10, -2, -3 };
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int largestNumberPosition = i;

                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[largestNumberPosition])
                    {
                        largestNumberPosition = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[largestNumberPosition];
                numbers[largestNumberPosition] = temp;
            }

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            //Todo Look up different sorting methods online like Bubble Sort


            //list

            //write a program that uses a list called names with the names Craig and Greg already inside the list
            List<string> names = new List<string> {"Craig", "Greg"};
            //Then add to the list two more names
            names.Add("Luke");
            names.Add("Ren");
            //Finally, add this list of names to your current list 
            List<string> myNames = new List<string> { "Sam", "Donn", "Micky", "Ramez" };
            names.AddRange(myNames);
            //Remove the name "Craig" from the list
            names.Remove("Craig");

            //queue
            //dictionary
            //stack
        }
    }
}