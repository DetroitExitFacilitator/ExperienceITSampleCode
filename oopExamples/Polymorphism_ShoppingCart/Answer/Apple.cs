namespace Polymorphism_ShoppingCart
{
    public class Apple : Item
    {
        public Apple(string appleType)
        {
            Name = appleType + " Apple";
            Value = 2;
        }
    }
}