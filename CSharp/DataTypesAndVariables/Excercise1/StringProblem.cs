using System;
using System.Linq;

namespace DataTypesAndVariables.Excercise1
{
    public class StringProblem
    {
        public static void Main(string[] args)
        {
            method();
            //To use this class Click the solution Explorer tab.
            //To start this class right click the project and select properties.
            //Select the application option and set the start up to object to this class example found here.


            //  Write a program that will prompt the user to enter in the message
            //  "Mary had a little lamb"

            //  replace all the white space in the message with a , promgramatically and print the result to the console.

            //Expected output
            // Mary,had,a,little,lamb


            // Next print the orignal message without white space
            // Expected output:
            //      Maryhadalittlelamb


            //Prompt the user to enter their first name

            //Next, create a formattable string that will let you change names based on the user input
            //      expected output if the variable contained the name Seth
            //      Seth had a little lamb.

            // Print the original message in all capitals.

            // Print the original message in lower case.

            //Print the length of the original string to the console.

            //Combine the original message with a new message and then display to the console
            //Ex: Mary had a little lamb who's fleece was white as snow

            Console.ReadLine();
        }

        public static void method()
        {
            //  Write a program that will prompt the user to enter in the message
            //  "Mary had a little lamb"
            string expectedPhrase = "Mary had a little lamb";
            Console.WriteLine($"Please enter the phrase: {expectedPhrase}");
            string phrase = Console.ReadLine();

            Console.WriteLine();

            //  replace all the white space in the message with a , promgramatically and print the result to the console.
            var commaSeperatedPhrase = phrase.Replace(" ", ",");
            Console.WriteLine(commaSeperatedPhrase);

            //Expected output
            // Mary,had,a,little,lamb


            // Next print the orignal message without white space
            var noSpacePhrase = phrase.Replace(" ", "");
            Console.WriteLine(noSpacePhrase);


            //Prompt the user to enter their first name
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            //Next, create a formattable string that will let you change names based on the user input but still declares "had a little lamb"
            var myNamePhrase = string.Format("{0} had a little lamb", firstName);
            Console.WriteLine(myNamePhrase);

            // Print the original message in all capitals.
            var capitalizedPhrase = phrase.ToUpper();
            Console.WriteLine(capitalizedPhrase);

            // Print the original message in lower case.
            var lowercasePhrase = phrase.ToLower();
            Console.WriteLine(lowercasePhrase);

            //Print the length of the original string to the console.
            var lengthOfPhrase = phrase.Length;
            Console.WriteLine("The length of the phrase is " + lengthOfPhrase);

            //Combine the original message with a new message and then display to the console
            //Ex: Mary had a little lamb who's fleece was white as snow
            var combinedPhrase = phrase + " who's fleece was whie as snow";
            Console.WriteLine(combinedPhrase);

            Console.ReadLine();
        }
    }
}
