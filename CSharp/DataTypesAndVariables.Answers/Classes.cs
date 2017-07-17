using System;
using DataTypesAndVariables.Answers.DiffNamespace;

namespace DataTypesAndVariables.Answers
{
    public class Classes
    {
        public static void Main(string[] args)
        {
            //create a class called Human
            //add two properties. One is a string and it should be called FirstName with a public get and a private set the other is an int and should be Age
            //Add a default constructor that sets the FirstName property to Crowley and then add a constructor that takes in a string and sets the FirstName property

            //create methods
            //create a public method called DisplayAge that displays the age of the Human as "I am x years old" where x is the Age of the Human
            //create another public method called NameMashup that takes in a string lastName
            //   inside this method, create a variable called mashup and combine the FirstName property with the lastName value being passed in and then
            //   return the variables value to the caller

            //Todo in answer code, explain diff between variable and properties

            //instance of a class/object
            //Now that you have defined a class (Human), create an instance of Human called dean and use the default/no argument constructor
            Human dean = new Human();
            //then create another instance called sam but use the constructor that takes a string argument
            Human sam = new Human("Dave");
            //on both of your instances, call their Age property and give it a value. Make the value different for both instances
            dean.Age = 12;
            sam.Age = 14;
            //invoke the method DisplayAge on both of your instances
            dean.DisplayAge();
            sam.DisplayAge();
            //invoke the method NameMashup for both of your instances
            dean.NameMashup("Crawford");
            sam.NameMashup("Lewis");

            //todo in answer code, describe difference between reference and primitive types
            //use class from other namespace
            //In the SolutionExplorer, under DataTypesAndVariables project, create a new file in the DiffNamespace folder
            //In that file, define a class called Animal with 3 string properties (Name, Species, Color) and a default constructor. Set the properties in the constructor
            //Back in your main program, create an instance of that newly created class called dog 
            Animal dog = new Animal();
            //now display the variables on the screen like "My name is {name} I am a {species} and my color is {color}
            Console.WriteLine($"My name is {dog.Name} I am a {dog.Species} and my color is {dog.Color}");

            Console.ReadLine();
        }
    }

    public class Human
    {
        public string FirstName { get; private set; }
        public int Age { get; set; }

        public Human()
        {
            FirstName = "Crowley";
        }

        public Human(string firstName)
        {
            FirstName = firstName;
        }

        public void DisplayAge()
        {
            Console.WriteLine($"I am {Age} years old");
        }

        public string NameMashup(string lastName)
        {
            string mashup = $"{FirstName} {lastName}";
            return mashup;
        }
    }
}