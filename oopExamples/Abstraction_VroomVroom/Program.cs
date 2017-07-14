using System;

namespace Abstraction_VroomVroom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestDriveCar();
            TestDriveSubmarine();
        }

        public static void TestDriveCar()
        {
            IDriveable car = new Car();
            var testDriving = true;

            while (testDriving)
            {
                DisplayCarOptions();

                var decision = Console.ReadLine();
                int numericDecision;

                while (!int.TryParse(decision, out numericDecision) || (numericDecision < 1 || numericDecision > 4))
                {
                    Console.WriteLine("That is not a valid option, please select again.\n");

                    DisplayCarOptions();

                    decision = Console.ReadLine();
                }

                switch (numericDecision)
                {
                    case 1:
                        Console.WriteLine("Enter a valid speed to increase to: ");
                        var increase = Console.ReadLine();
                        var increaseSpeed = GetNumberFromString(increase, "Enter a valid speed to increase to: ");

                        car.PressGas(increaseSpeed);
                        break;
                    case 2:
                        Console.WriteLine("Enter a valid speed to decrease to: ");
                        var decrease = Console.ReadLine();
                        var decreaseSpeed = GetNumberFromString(decrease, "Enter a valid speed to decrease to: ");

                        car.PressBrake(decreaseSpeed);
                        break;
                    case 3:
                        Console.WriteLine("Enter a degree to turn the wheel: ");
                        var degree = Console.ReadLine();
                        var degreeChange = GetNumberFromString(degree, "Enter a degree to turn the wheel: ");

                        car.ChangeDirection(degreeChange);
                        break;
                    case 4:
                        testDriving = false;
                        break;
                }
            }
        }

        public static void TestDriveSubmarine()
        {
            var sub = new Submarine();
            var testDriving = true;

            while (testDriving)
            {
                DisplaySubmarineOptions();

                var decision = Console.ReadLine();
                int numericDecision;

                while (!int.TryParse(decision, out numericDecision) || (numericDecision < 1 || numericDecision > 6))
                {
                    Console.WriteLine("That is not a valid option, please select again.\n");

                    DisplaySubmarineOptions();

                    decision = Console.ReadLine();
                }

                switch (numericDecision)
                {
                    case 1:
                        Console.WriteLine("Enter a valid speed to increase to: ");
                        var increase = Console.ReadLine();
                        var increaseSpeed = GetNumberFromString(increase, "Enter a valid speed to increase to: ");

                        sub.PressGas(increaseSpeed);
                        break;
                    case 2:
                        Console.WriteLine("Enter a valid speed to decrease to: ");
                        var decrease = Console.ReadLine();
                        var decreaseSpeed = GetNumberFromString(decrease, "Enter a valid speed to decrease to: ");

                        sub.PressBrake(decreaseSpeed);
                        break;
                    case 3:
                        Console.WriteLine("Enter a degree to turn the submarine: ");
                        var degree = Console.ReadLine();
                        var degreeChange = GetNumberFromString(degree, "Enter a degree to turn the submarine: ");

                        sub.ChangeDirection(degreeChange);
                        break;
                    case 4:
                        sub.Submerge();
                        break;
                    case 5:
                        sub.Emerge();
                        break;
                    case 6:
                        testDriving = false;
                        break;
                }
            }
        }

        public static void DisplayCarOptions()
        {
            Console.WriteLine("Options While Driving:");
            Console.WriteLine("1 - Increase Speed");
            Console.WriteLine("2 - Decrease Speed");
            Console.WriteLine("3 - Turn Wheel");
            Console.WriteLine("4 - End Test Drive");

            Console.WriteLine("\nWhat would you like to do?");
        }

        public static void DisplaySubmarineOptions()
        {
            Console.WriteLine("Options While Driving:");
            Console.WriteLine("1 - Increase Speed");
            Console.WriteLine("2 - Decrease Speed");
            Console.WriteLine("3 - Turn Wheel");
            Console.WriteLine("4 - Dive");
            Console.WriteLine("5 - Ascend");
            Console.WriteLine("6 - End Test Drive");

            Console.WriteLine("\nWhat would you like to do?");
        }

        public static int GetNumberFromString(string value, string request)
        {
            int number;
            var isNumeric = int.TryParse(value, out number);

            while (!isNumeric)
            {
                Console.WriteLine(request);
                value = Console.ReadLine();

                isNumeric = int.TryParse(value, out number);
            }

            return number;
        }
    }
}
