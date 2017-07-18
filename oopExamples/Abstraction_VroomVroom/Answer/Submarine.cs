using System;

namespace Abstraction_VroomVroom.Answer
{
    public class Submarine : IDriveable, ISubmersible
    {
        private int Velocity { get; set; }
        private int Depth { get; set; }

        public void PressGas(int desiredSpeed)
        {
            if (Velocity > desiredSpeed)
            {
                Console.WriteLine($"Press the brake if you want to only be moving at {desiredSpeed} MPH.");
            }
            else if (Velocity == desiredSpeed)
            {
                Console.WriteLine("No change required, still cruising. ");
            }
            else
            {
                if (desiredSpeed > 50)
                {
                    Console.WriteLine($"The engine has started to smoke, but still increasing speed to {desiredSpeed} MPH.");
                }
                else
                {
                    Console.WriteLine($"Increasing speed to {desiredSpeed} MPH.");
                }
                Velocity = desiredSpeed;
            }

            Console.WriteLine();
        }

        public void PressBrake(int desiredSpeed)
        {
            if (Velocity < desiredSpeed)
            {
                Console.WriteLine($"Already traveling slower than {desiredSpeed} MPH.");
            }
            else if (Velocity == desiredSpeed)
            {
                Console.WriteLine("No change required, still cruising.");
            }
            else
            {
                Console.WriteLine($"Decreasing speed to {desiredSpeed} MPH.");
                Velocity = desiredSpeed;
            }
            Console.WriteLine();
        }

        public void ChangeDirection(int degrees)
        {
            if (degrees > 90)
            {
                Console.WriteLine("You feel resistance while turning the handles because you can't turn the handles more than 90 degrees.");
            }
            else if (degrees > 45)
            {
                Console.WriteLine($"Turning the submarine to the right {degrees - 45} degrees.");
            }
            else if (degrees < 45)
            {
                Console.WriteLine($"Turning the submarine to the left {45 - degrees} degrees.");
            }
            else if (degrees == 45)
            {
                Console.WriteLine("No change is being made, still traveling in the current direction.");
            }
            else
            {
                Console.WriteLine("Invalid input. That's not how submarines work.");
            }

            Console.WriteLine();
        }

        public void Submerge()
        {
            if (Depth == 20)
            {
                Console.WriteLine("Can't dive any deeper without breaking the ship.");
                Console.WriteLine($"Maintaining a depth of {Depth} feet.");
            }
            else
            {
                Console.WriteLine("Dive! Dive! Dive!");
                Depth += 10;
                Console.WriteLine($"Now at a depth of {Depth} feet.");
            }

            Console.WriteLine();
        }

        public void Emerge()
        {
            if (Depth == 0)
            {
                Console.WriteLine("We're already at the surface, mouth breather...");
            }
            else
            {
                Console.WriteLine("Ascend! Ascend! Ascend!");
                Depth -= 10;
                Console.WriteLine($"Maintaining a depth of {Depth} feet.");
            }

            Console.WriteLine();
        }
    }
}