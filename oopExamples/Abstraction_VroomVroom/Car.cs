using System;

namespace Abstraction_VroomVroom
{
    /// <summary>
    /// This is an example of abstraction because this class does not fully embody all the functionality of a car
    /// It pulls away all the nitty gritty details (abstracts it) of driving and provides you simple functionality
    /// of going faster, slower, and turning. There are a lot of other classes/objects working behind the scenes
    /// to provide this ease of use, but the user doesn't need to know how all that works. They just need to know
    /// that when they call PressGas, the car will speed up; PressBrake and it will slow down.
    /// </summary>
    public class Car : IDriveable
    {
        private int Velocity  { get; set; }

        /// <summary>
        /// Increase the speed of  the car to the desired speed.
        /// </summary>
        /// <param name="desiredSpeed">Speed at which the car should increase velocity to</param>
        public void PressGas(int desiredSpeed)
        {
            if (Velocity > desiredSpeed)
            {
                Console.WriteLine($"Press the brake if you want to only be moving at {desiredSpeed} MPH.");
            }
            else if (Velocity == desiredSpeed)
            {
                Console.WriteLine("No change required, still crusing. ");
            }
            else
            {
                Console.WriteLine($"Increasing speed to {desiredSpeed} MPH.");
                Velocity = desiredSpeed;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Decrease the speed of the car to the desired speed.
        /// </summary>
        /// <param name="desiredSpeed">Speed at which the car should slow down to</param>
        public void PressBrake(int desiredSpeed)
        {
            if (Velocity < desiredSpeed)
            {
                Console.WriteLine($"Already traveling slower than {desiredSpeed} MPH.");
            }
            else if (Velocity == desiredSpeed)
            {
                Console.WriteLine("No change required, still crusing.");
            }
            else
            {
                Console.WriteLine($"Decreasing speed to {desiredSpeed} MPH.");
                Velocity = desiredSpeed;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Turn the wheel between 0-360 degrees to change direction
        /// </summary>
        /// <param name="degrees">Input from 0-360 degrees to change direction of car.</param>
        public void ChangeDirection(int degrees)
        {
            if (degrees > 360)
            {
                Console.WriteLine("You feel resistance while turning the wheel because you can't turn the wheel more than 360 degrees.");
            }
            else if (degrees > 180)
            {
                Console.WriteLine($"Turning the car to the right {degrees - 180} degrees.");
            }
            else if (degrees < 180)
            {
                Console.WriteLine($"Turning the car to the left {180 - degrees} degrees.");
            }
            else if (degrees == 180)
            {
                Console.WriteLine("No change is being made, still traveling in the current direction.");
            }
            else
            {
                Console.WriteLine("Invalid input. That's not how wheels work.");
            }
        }
    }
}