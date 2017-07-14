using System;

namespace Encapsulation_HackerParadise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HackIt();
        }

        public static void HackIt()
        {
            var hackerName = "Hackerman";
            var privateHuman = new PrivateHuman();
            var internalHuman = new InternalHuman();
            var publicHuman = new PublicHuman();
            var protectedChild = new ProtectedChild();

            Console.WriteLine($"{hackerName}: I'm going to expose all your vulnerabilities! MWAHAHAHA!!!");
            Console.WriteLine($"{hackerName}: Let's start with the PublicHuman... your Social Security Number is {publicHuman.SocialSecurityNumber}.");

            Console.WriteLine($"{hackerName}: Now I will destroy InternalHuman's life... your Social Security Number is {internalHuman.SocialSecurityNumber}.");

            Console.WriteLine($"{hackerName}: I'm on a roll! Next I think I will steal the recipe to Noodle soup.");
            Console.WriteLine($"{hackerName}: I know ProtectedChild knows the secret, I'll just steal the secret ingredient from him.... ");
            Console.WriteLine($"{hackerName}: Blast it, this kid learned from his ProtectiveParent not to share the ingredient with supreme hackers like myself.");
            Console.WriteLine($"{hackerName}: But maybe under the right circumstances, ProtectedChild would spill the beans himself... (a few drinks later)");
            protectedChild.SpillTheFamilySecrets();

            Console.WriteLine($"{hackerName}: That's fine, I'll go back to stealing Social Security Numbers. Give me your numbers, PrivateHuman!");
            Console.WriteLine($"{hackerName}: Rejected again! Looks like Team Rocket is blasting off againnnnnn.......");

            Console.WriteLine();

            Console.WriteLine("Now let's see how the ExternalHacker fairs in obtaining information...");
        }
    }
}