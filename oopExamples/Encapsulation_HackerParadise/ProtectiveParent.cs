namespace Encapsulation_HackerParadise
{
    public abstract class ProtectiveParent
    {
        protected string FamilyRecipeSecretIngredient { get; set; }

        protected ProtectiveParent()
        {
            FamilyRecipeSecretIngredient = "There is no secret ingredient";
        }
    }
}