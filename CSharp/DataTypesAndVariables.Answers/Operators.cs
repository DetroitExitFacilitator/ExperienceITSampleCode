using System;

namespace DataTypesAndVariables.Answers
{
    public class Operators
    {
        public static void Main(string[] args)
        {
            //write a program that uses an integer with value of 9
            int digit = 9;
            Console.WriteLine($"Our initial value is {digit}. We'll refer to this inital value as digit{Environment.NewLine}");


            //have that integer use the addition operator to add itself with itself
            digit += 9;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($" += operator adds a number to a variable's value. So, 'digit += 9' will add 9 to the value of digit. digit's value is now {digit}{Environment.NewLine}");


            //use that integer again and subtract 2 from itself using the subtraction operator
            digit -= 2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" -= operator subtracts a number from a variable's value. So, 'digit -= 2' will subtract 2 from the value of digit. digit's value is now {digit} {Environment.NewLine}");


            //use the multiplication operator to multiply the integer by 8
            digit *= 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" *= operator will multiply the number by the variable's value. So, 'digit *= 8' will multiply 8 by the value of digit. digit's value is now {digit}{Environment.NewLine}");


            //use the division operator to divide the integer by 3
            digit /= 3;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" /= operator will divide digit's value by the number. So, 'digit /= 3' will divide the value of digit by two. digit's value is now {digit}{Environment.NewLine}");


            //use the modulus operator to mod the integer by 10
            digit %= 10;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" %= operator will divide digit's value by the number. However, it sets the remainder of the division as the value of digit. So, 'digit %= 10' will divide the value of digit by two but store it's remainder as the value. digit's value is now {digit}{Environment.NewLine}");

            Console.ReadKey();

        }
    }
}