using System;

namespace Encapsulation_HackerParadise
{
    public class ProtectedChild : ProtectiveParent
    {
        public void SpillTheFamilySecrets()
        {
            Console.WriteLine("I can spill the family secrets, but you'll never get them from me any other way.");
            Console.WriteLine("The secret ingredient is......");
            Console.WriteLine($"{FamilyRecipeSecretIngredient}. ~Kung Fu Panda");
        }
    }
}