using System;
using System.Collections.Generic;

namespace Polymorphism_ShoppingCart
{
    public class ShoppingCart
    {
        public List<Item> Items { get; private set; }

        public ShoppingCart()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void ScanItem(Item item)
        {
            Console.WriteLine($"Scanning {item.Name}... Price ${item.Value}");
        }

        public int TotalCost()
        {
            var total = 0;

            foreach (var item in Items)
            {
                total += item.Value;
            }

            return total;
        }
    }
}