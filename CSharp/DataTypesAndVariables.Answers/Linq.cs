using System;
using System.Collections.Generic;
using System.Linq;

namespace DataTypesAndVariables.Answers
{
    public class Linq
    {
        public static void Main(string[] args)
        {
            //use this list for the linq examples (except for Select and SelectMany, that will use a different list)
            var list = new List<string> { "Aang", "Megaman", "Homer", "Rick", "Summer", "Bob", "Louise", "Archer", "Stan", "Rodger", "Sozin" };

            //where
            //Write a program that uses the linq method Where to find all the names that start with capital S and print the names
            var namesThatStartWithS = list.Where(n => n.StartsWith("S")); //or n[0] == 'S'
            foreach (var name in namesThatStartWithS)
            {
                Console.WriteLine($"{name} ");
            }
            //Write a program that uses the linq method Where to find all names that contain the letter 'w' lowercase and print the number of names
            var namesThatContainW = list.Where(n => n.Contains('w'));
            Console.WriteLine($"Names that contain the letter 'w': {namesThatContainW.Count()}");
            

            //first
            //Write a program that uses the linq method First to print the first name that has the letter 'c' lowercase in it
            var firstNameWithC = list.First(n => n.Contains('c'));
            Console.WriteLine($"First name that contains the letter 'c' is: {firstNameWithC}");

            //Write a program that uses the linq method First to print the first name that has 15 letters in it

            //This will throw an exception
            //var firstNameWith15LettersErr = list.First(n => n.Length >= 15);

            //Write a program that uses the linq method FirstOrDefault to print the first name that has 15 letters in it
            var firstOrDefaultNameWith15Letters = list.FirstOrDefault(n => n.Length >= 15);
            Console.WriteLine($"Name with 15 letters or more: {firstOrDefaultNameWith15Letters}");

            //single
            //Write a program that uses the linq method Single to print the name that contains the letter 'z' lowercase
            var onlyNameWithZ = list.Single(n => n.Contains('z'));
            Console.WriteLine($"The only name with the letter z is: {onlyNameWithZ}");

            //Write a program that uses the linq method Single to print the name that contains the letter 's' lowercase

            //This will throw an exception
            //var errorOnlyNameWithS = list.Single(n => n.Contains('s'));

            //Write a program that uses the linq method SingleOrDefault to print the name that contains the letter 's' lowercase
            var onlyNameWithS = list.SingleOrDefault(n => n.Contains('s'));
            Console.WriteLine($"The only name that contains the letter 's': {onlyNameWithS}");


            //Select and SelectMany
            var classRoom = LoadClassroom();

            //Write a program that uses the Select linq statement to get the name of all the students in the classroom
            var studentNames = classRoom.Select(s => s.Name);
            foreach (var name in studentNames)
            {
                Console.Write($"{name} ");
            }

            //Write a program that uses the SelectMany linq statement to get a list of all the class names where the subject is math
            var classNames = classRoom.SelectMany(s => s.Classes).Where(c => c.Subject == "Math").Select(c => c.Name);
            foreach (var className in classNames)
            {
                Console.Write($"{className} ");
            }
        }

        private static List<Student> LoadClassroom()
        {
            var classroom = new List<Student>
            {
                new Student
                {
                    Name = "Jimmy Jahns",
                    Grade = 12,
                    Classes = new List<Class> { new Class { Name = "Diff Eq", Subject = "Math"}, new Class{ Name = "Calculus 5", Subject = "Math"}}
                },
                new Student
                {
                    Name = "Silly Sally",
                    Grade = 8,
                    Classes = new List<Class> {new Class { Name = "Michigan History", Subject = "History"} }
                },
                new Student
                {
                    Name = "Billy Bob",
                    Grade = 12,
                    Classes = new List<Class> { new Class { Name = "Algebra", Subject = "Math" } }
                }
            };

            return classroom;
        }

        private class Student
        {
            public string Name { get; set; }
            public int Grade { get; set; }
            public List<Class> Classes { get; set; }
        }

        private class Class
        {
            public string Name { get; set; }
            public string Subject { get; set; }
        }
    }
}