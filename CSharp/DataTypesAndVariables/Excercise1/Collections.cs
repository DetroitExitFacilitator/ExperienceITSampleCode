using System.Collections.Generic;

namespace DataTypesAndVariables.Excercise1
{
    public class Collections
    {
        public static void Main(string[] args)
        {
            //array
            //write a program that creates an array with a size of 5 elements
            //Then create a loop that will add the odd numbers between 0 and 10 to the array

            //again create a program that creates an array with a size of 5 elements
            //this time create a loop that will add the even numbers between 0 and 20 to the array

            //Finally, for arrays, create a program that will sort this array of numbers from highest to lowest
            //Todo Look up different sorting methods online like Bubble Sort


            //list

            //write a program that uses a list with the names Craig and Greg already inside the list
            //Then add to the list two more names
            //Finally, add this list of names to your current list 
            List<string> myNames = new List<string> { "Sam", "Donn", "Micky", "Ramez" };
            //Remove the name "Craig" from the list


            //queue
            //A queue is a collection of objects that are stored and processed in a FIFO(First in, First out) order.
            //The object that is added in first will also be the first object to be processed.
            //Whenever an operation is applied to a queue, the objects that were added first will be processed first.


            //Write a program that uses a queue to print a list of names in a FIFO order.

            //Add a list of names to the queue, as many as you'd like. (at least 5)
            //print each name to the console in a first in, first out order.

            //Remove the first element of the queue using dequeue() and print the names once more

            //Use Peek() to view the first element in the queue without removing it.

            //dictionary

            // Write a program that uses dictionary called employeeCoolnessFactor that holds an 
            //employee's name as a string and a coolness value as an int, with the employee names 
            //Craig and Greg already inside the dictionary.

            // Then add two more names to the list

            // Find out how cool Craig is by retrieveing the value by using his name (the key).

            // Lets compare Seth and Craig and see who is cooler.

            //stack

            // This is a great write up of what a stack is: 'https://www.codeproject.com/Articles/17029/The-use-of-Stacks-in-C'
            // Write a program that holds 5 names in a stack.

            // Display the stack to compare

            // Use the Peek funtion to see the last item in the stack.

            // Use the Pop function to remove the last item from the stack.
        }
    }
}