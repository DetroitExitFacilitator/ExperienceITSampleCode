using System;
using Encapsulation_HackerParadise;

namespace Encapsulation_ExternalAttack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TryToStealInfo();
        }

        public static void TryToStealInfo()
        {
            var internalHuman = new InternalHuman();
            var privateHuman = new PrivateHuman();
            var publicHuman = new PublicHuman();
            var protectedChild = new ProtectedChild();

            Console.WriteLine("Trying to access InternalHuman's SSN:");
            //var ssn = internalHuman.SocialSecurityNumber; //This is not visible in this assembly because the access modifier is "internal"
            Console.WriteLine("Cannot access InternalHuman's SSN because we are not in the same assembly.");
            Console.WriteLine();

            Console.WriteLine("Trying to access PrivateHuman's SSN:");
            //var ssn = privateHuman.SocialSecurityNumber; //Cannot access because SocialSecurityNumber is only available for PrivateHuman to see and work with
            Console.WriteLine("Cannot access PrivateHuman's SSN because only PrivateHuman can see the SSN.");
            Console.WriteLine();

            Console.WriteLine("Trying to access PublicHuman's SSN:");
            var ssn = publicHuman.SocialSecurityNumber; //This is available to anyone, regardless of the assembly because its access modifier is "public"
            Console.WriteLine($"PublicHuman is not protected in any way, SSN is: {ssn}.");
            Console.WriteLine();

            Console.WriteLine("Trying to access the secret ingredient to Noodle soup from ProtectedChild:");
            //var secretIngredient = protectedChild.FamilyRecipeSecretIngredient; //Cannot access this because the parent protected this property for itself (ProtectiveParent) and future "generations" (ProtectedChild)
            Console.WriteLine($"Cannot access the FamilyRecipeSecretIngredient because only ProtectiveParent and its descendants can see/use it.");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
