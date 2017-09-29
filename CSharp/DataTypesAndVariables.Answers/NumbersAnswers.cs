using System;

namespace DataTypesAndVariables.Answers
{
    public class NumbersAnswers
    {
        public static void Main()
        {
            //Create a program that will do the following and write all results to the console 
            //Make sure to write an understandable message with each result so you can easily read it at the end
            //EX If adding two numbers together, display to the console a message like 
            //"Adding (the first number you chose) + (the second number) = (the result)"

            IntegerAnswers();
            DoubleAnswers();
            DoubleMeetsIntegerAnswer();
            DecimalMeetsIntegerAnswer();
            BooleanOperatorsAnswer();
            ObjectAnswers();
            Console.ReadLine();
        }

        public static void IntegerAnswers()
        {
            //Add two ints 
            int add1 = 1;
            int add2 = 3;
            int additionResult = add1 + add2;
            Console.WriteLine($"Adding {add1} + {add2} = {additionResult}");

            //Subtract two ints
            int subtract1 = 5;
            int subtract2 = 3;
            int subtractionResult = subtract1 - subtract2;
            Console.WriteLine($"Subtracting {subtract1} - {subtract2} = {subtractionResult}");

            //Multiply two ints 
            int multiply1 = 3;
            int multiply2 = 4;
            int multiplicationResult = multiply1 * multiply2;
            Console.WriteLine($"Multiplying {multiply1} * {multiply2} = {multiplicationResult}");

            //Divide two ints 
            int divide1 = 10;
            int divide2 = 2;
            int divisionResult = divide1 / divide2;
            Console.WriteLine($"Dividing {divide1} / {divide2} = {divisionResult}");

            //Mod two ints
            int mod1 = 11;
            int mod2 = 3;
            int modulusResult = mod1 % mod2;
            Console.WriteLine($"Modulus of {mod1} % {mod2} = {modulusResult}");

            //Print the minvalue of an int using the min value method
            int intMinValue = int.MinValue;
            Console.WriteLine($"The minimum value of an int is {intMinValue}");

            //Print the maxvalue of an int using the max value method
            int intMaxValue = int.MaxValue;
            Console.WriteLine($"The maximum value of an int is {intMaxValue}");

            //Add max value of int to max value of int and print the result as int
            int maxVal1 = int.MaxValue;
            int maxVal2 = int.MaxValue;
            int maxResult = maxVal1 + maxVal2;

            Console.WriteLine($"Adding int max values {maxVal1} + {maxVal2} = {maxResult}");

            //Make a variable with keyword type int and then make a string variable and call the type of the int variable you made
            int number = 3;
            string type = number.GetType().ToString();
            Console.WriteLine($"The type of keyword int is {type}");
        }

        public static void DoubleAnswers()
        {
            //Add two doubles together
            double doubleAdd1 = 20.239023;
            double doubleAdd2 = 9.202;
            double doubleAddResult = doubleAdd1 + doubleAdd2;
            Console.WriteLine($"Adding two doubles {doubleAdd1} + {doubleAdd2} = {doubleAddResult}");

            //Subtract two doubles 
            double dSubtract1 = 390.2222;
            double dSubtract2 = 239.39023;
            double dSubtractionResult = dSubtract1 = dSubtract2;
            Console.WriteLine($"Subtracting two doubles {dSubtract1} - {dSubtract2} = {dSubtractionResult}");

            //Multiply two doubles 
            double dMultiply1 = 3.39023;
            double dMultiply2 = 9.38232222;
            double dMultiplacationResult = dMultiply1 * dMultiply2;
            Console.WriteLine($"Multiplying two doubles {dMultiply1} * {dMultiply2} = {dMultiplacationResult}");

            //Divide two doubles 
            double dDivide1 = 9.28302;
            double dDivide2 = 8.237820;
            double dDivisionResult = dDivide1 / dDivide2;
            Console.WriteLine($"Dividing two doubles {dDivide1} / {dDivide2} = {dDivisionResult}");

            //Mod two doubles
            double dMod1 = 48.202;
            double dMod2 = 8.22222222;
            double dModulusResult = dMod1 / dMod2;
            Console.WriteLine($"Modulus of two doubles {dMod1} % {dMod2} = {dModulusResult}");

            double doublePrecision = 2902.380320;
            //Print the results of doublePrecision displaying two decimal places
            Console.WriteLine($"{doublePrecision:2d}");

            //Print the results of doublePrecision diplaying 4 decimal places
            Console.WriteLine($"{doublePrecision:4d}");

            //Print the max value of a double
            double dMaxValue = double.MaxValue;
            Console.WriteLine($"Max value of a double is {dMaxValue}");

            //Print the min value of a double
            double dMinValue = double.MinValue;
            Console.WriteLine($"Min value of a double is {dMinValue}");

            //Add max value of double to max value of double and print the result as int
            double maxVal1 = double.MaxValue;
            double maxVal2 = double.MaxValue;
            double maxResult = maxVal1 + maxVal2;

            Console.WriteLine($"Adding double max values {maxVal1} + {maxVal2} = {maxResult}");

            //Make a variable with keyword type int and then make a string variable and call the type of the int variable you made
            double number = 3;
            string type = number.GetType().ToString();
            Console.WriteLine($"The type of keyword double is {type}");
        }

        public static void DoubleMeetsIntegerAnswer()
        {
            //Divide an int value by a double and capture the value and then print the result and then the results type;
            int integerValue = 6;
            double doubleValue = 2.999;
            var result = integerValue / doubleValue;

            string resultType = result.GetType().ToString();
            Console.WriteLine($"The value result of the integer and double division is {result}.");
            Console.WriteLine($"The resulting type of the integer and double division is {resultType}.");
        }

        public static void DecimalMeetsIntegerAnswer()
        {
            //Create an integer number and decimal number and divide the integer by the decimal
            //Display the results and the results type
            int integerValue = 9;
            decimal decimalValue = 3.0000m;
            var result = integerValue / decimalValue;

            string resultType = result.GetType().ToString();
            Console.WriteLine($"The result of dividing the integer by the decimal is {result}");
            Console.WriteLine($"The resulting type of the integer and decimal division is {resultType}.");
        }

        public static void BooleanOperatorsAnswer()
        {
            //What would be the result of true && false, true && true, false && true, and false && false
            bool andResult1 = true && true;
            bool andResult2 = true && false;
            bool andResult3 = false && true;
            bool andResult4 = false && false;
            Console.WriteLine($"The result of true and true is {andResult1}");
            Console.WriteLine($"The result of true and false is {andResult2}");
            Console.WriteLine($"The result of false and true is {andResult3}");
            Console.WriteLine($"The result of false and false is {andResult4}");

            bool orResult1 = true || true;
            bool orResult2 = true || false;
            bool orResult3 = false || true;
            bool orResult4 = false || false;
            //What would be the result of true || true, true || false, false || true, false || false
            Console.WriteLine($"The result of true and true is {orResult1}");
            Console.WriteLine($"The result of true and false is {orResult2}");
            Console.WriteLine($"The result of false and true is {orResult3}");
            Console.WriteLine($"The result of false and false is {orResult4}");

            bool notResult1 = true ^ true;
            bool notResult2 = true ^ false;
            bool notResult3 = false ^ true;
            bool notResult4 = false ^ false;
            //What would be the result of true ^ true, true ^ false, false ^ true, false ^ false
            Console.WriteLine($"The result of true and true is {notResult1}");
            Console.WriteLine($"The result of true and false is {notResult2}");
            Console.WriteLine($"The result of false and true is {notResult3}");
            Console.WriteLine($"The result of false and false is {notResult4}");

            //Make a variable with keyword type bool and then make a string variable and call the type of the int variable you made
            bool value = true;
            string type = value.GetType().ToString();
            Console.WriteLine($"The type of keyword bool is {type}");
        }

        public static void ObjectAnswers()
        {
            //Create two objects
            object obj1 = new object();
            object obj2 = new object();

            //Compare the two objects and see if they are the same
            bool result1 = obj2.Equals(obj1);
            Console.WriteLine($"Objects 1 and 2 are the same: {result1}");

            //Create another object
            object obj3 = new object();
            //Now create another object that is set to the value of the last object you created
            object obj4 = obj3;

            //Compare the last 2 objects together, do you think they are the same?
            bool result2 = obj4.Equals(obj3);
            Console.WriteLine($"Obj4 instantiated with the value of Obj3 is the same: {result2}");

            //Call .ToString() on the last two objects you made
            Console.WriteLine($"Obj3 .ToString() = {obj3.ToString()} Obj4 .ToString() = {obj4.ToString()}");

            //Get the type of the instance of the last object you made, represented as a string
            string objectType = obj4.GetType().ToString();
            Console.WriteLine($"The  type of Obj4 is {objectType}");
        }

    }
}