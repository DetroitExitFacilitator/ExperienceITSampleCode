using System;

namespace DataTypesAndVariables.Answers
{
    public class IfAndSwitch
    {
        public static void Main(string[] args)
        {
            //if statements, if else, else
            //switch statement

            //Write a program using if statements that when given an integer between 0 and 100 returns
            //the letter grade A, B, C, D, or F
            //0-60 receives a F
            //61-70 receives a D
            //71-80 recieves a C
            //81-90 recieves a B
            //91-100 recieves an A
            //If they provide anything else, return ERR
            Console.WriteLine("Please enter an integer grade point between 0 and 100");
            string response = Console.ReadLine();
            int gradeValue;
            int.TryParse(response, out gradeValue);
            string letterGrade = DetermineLetterGrade(gradeValue);
            Console.WriteLine($"Your letter grade is {letterGrade}");

            //Write a program using a switch statement that takes in a string letter grade and returns an int value
            //A = 95
            //B = 85
            //C = 75
            //D = 65
            //F = 0
            //anything else return -1
            Console.WriteLine("Please enter a single capital letter representing a letter grade");
            string letterResponse = Console.ReadLine();
            int numericGrade = SwitchLetterGrade(letterResponse);
            Console.WriteLine($"Your numeric grade is {numericGrade}");

        }

        public static string DetermineLetterGrade(int gradePoint)
        {
            if (gradePoint >= 0 && gradePoint <= 60)
                return "F";
            else if (gradePoint < 71)
                return "D";
            else if (gradePoint < 81)
                return "C";
            else if (gradePoint < 91)
                return "B";
            else if (gradePoint > 90 && gradePoint < 101)
                return "A";
            else
                return "ERR";
        }

        public static int SwitchLetterGrade(string letterGrade)
        {
            switch (letterGrade)
            {
                case "A":
                    return 95;
                case "B":
                    return 85;
                case "C":
                    return 75;
                case "D":
                    return 65;
                case "F":
                    return 0;
                default:
                    return -1;
            }
        }
    }
}