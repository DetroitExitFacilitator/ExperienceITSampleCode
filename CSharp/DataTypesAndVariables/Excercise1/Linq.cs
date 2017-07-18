using System.Collections.Generic;

namespace DataTypesAndVariables.Excercise1
{
    public class Linq
    {
        public static void Main(string[] args)
        {
            //use this list for the linq examples (except for Select and SelectMany, that will use a different list)
            var list = new List<string> { "Aang", "Megaman", "Homer", "Rick", "Summer", "Bob", "Louise", "Archer", "Stan", "Rodger", "Sozin" };

            //where
            //Write a program that uses the linq method Where to find all the names that start with S and print the names
            //Write a program that uses the linq method Where to find all names that contain the letter 'w' (lowercase) and print the number of names

            //first
            //Write a program that uses the linq method First to print the first name that has the letter 'c' lowercase in it
            //Write a program that uses the linq method First to print the first name that has 15 letters in it
            //Write a program that uses the linq method FirstOrDefault to print the first name that has 15 letters in it

            //single
            //Write a program that uses the linq method Single to print the name that contains the letter 'z' lowercase
            //Write a program that uses the linq method Single to print the name that contains the letter 's' lowercase
            //Write a program that uses the linq method SingleOrDefault to print the name that contains the letter 's' lowercase


            var classRoom = LoadClassroom();

            //Select and SelectMany

            //Write a program that uses the Select linq statement to get the name of all the students in the classroom
            //Write a program that uses the SelectMany linq statement to get a list of all the class names where the subject is math
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