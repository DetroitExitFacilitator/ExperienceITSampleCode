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
            //Write a program that uses a queue to print a list of names in a FIFO(First in, First Out) order.
            Queue<string> collectionOfNames = new Queue<string>();

            int index = 0;

            //Add a list of names to the queue (at least 5)
            collectionOfNames.Enqueue("Sam");
            collectionOfNames.Enqueue("Seth");
            collectionOfNames.Enqueue("Ramez");
            collectionOfNames.Enqueue("Greg");
            collectionOfNames.Enqueue("Craig");

            //print each name to the console in a first in, first out order.
            foreach (var name in collectionOfNames)
            {
                index += 1;
                Console.WriteLine(index + ".) " + name);
            }

            //Remove the first name from the queue and print the names once more.
            collectionOfNames.Dequeue();
            index = 0;
            foreach (var name in collectionOfNames)
            {
                index += 1;
                Console.WriteLine(index + ".) " + name);
            }

            //Use Peek() to view the first element in the queue without removing it.
            Console.WriteLine(collectionOfNames.Peek());


            //dictionary

            // Write a program that uses dictionary called employeeCoolnessFactor that holds an employee's name as a string and a coolness value as an int, with the employee names Craig and Greg already inside the dictionary.
            Dictionary<string, int> employeeCoolnessFactor = new Dictionary<string, int> { { "Craig", 10 }, { "Greg", 8 } };
            // Then add two more names to the list
            employeeCoolnessFactor.Add("Seth", 2);
            employeeCoolnessFactor.Add("Sam", 7);
            // Find out how cool Craig is by retrieveing the value by using his name (the key).
            Console.WriteLine($"Craig is a {employeeCoolnessFactor["Craig"]}/10 on the coolness scale!");
            // Lets compare Seth and Craig and see who is cooler.
            if (employeeCoolnessFactor["Craig"] > employeeCoolnessFactor["Seth"])
            {
                Console.WriteLine("Craig is the COOLEST!!!");
            }
            else
            {
                Console.WriteLine("Seth is the COOLEST!!!");
            }


            //stack

            // Write a program that holds 5 names in a stack.
            Stack<string> nameStack = new Stack<string>();
            nameStack.Push("Craig");
            nameStack.Push("Micky");
            nameStack.Push("Sam");
            nameStack.Push("Greg");
            nameStack.Push("Seth");
            // Display the stack to compare
            foreach (var name in nameStack)
            {
                Console.WriteLine($"{name}\n");
            }
            // Use the Peek funtion to see the last item in the stack.
            Console.WriteLine($"{nameStack.Peek()} is the last name added to the stack.");
            // Use the Pop function to remove the last item from the stack.
            nameStack.Pop();
            foreach (var name in nameStack)
            {
                Console.WriteLine($"{name}\n");
            }

        }
    }
}