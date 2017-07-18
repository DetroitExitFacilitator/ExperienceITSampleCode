using System;
using System.Collections.Generic;

namespace Polymorphism_ShoppingCart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GoShopping();
        }
        
        public static void GoShopping()
        {
            var items = new List<Item>
            {
                new Broom(),
                new Steak(),
                new Apple("Golden"),
                new Apple("Honey Crisp")
            };
            
            var cart = new ShoppingCart();

            foreach (var item in items)
            {
                cart.ScanItem(item);
                cart.AddItem(item);
            }

            var yourTotal = cart.TotalCost();

            Console.WriteLine();

            Console.WriteLine($"Your shopping total for today is: ${yourTotal}");
            Console.ReadLine();
        }
    }
}
