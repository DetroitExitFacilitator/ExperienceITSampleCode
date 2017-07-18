namespace Polymorphism_ShoppingCart
{
    public class Problem
    {
        //We want to create a shopping application where we can add
        //any item to a shopping cart and you should have the ability to 
        //scan items going in to the shopping cart and you should be able to
        //tally up the cost of the cart 

        //You will need a ShoppingCart class that contains a List to hold your objects
        
        //You will need to create a Broom, Apple, and Steak class that can be added to the ShoppingCart
        //Inside of Broom and Steak, set the Name and Price. For Apple, the constructor takes in a string name to prepend in from of the word " Apple" for the Name, set the Price
        //  Ex for Apple: Name = name + " Apple" so you would have something like Name = "Green Apple"

        //ShoppingCart has a a method called ScanItem that displays the name of the item going in to the cart as well as the value/price of the item
        //  Ex $"Scanning {item.Name}... Price ${item.Value}"
        
        //ShoppingCart has an AddItem method that adds an item to the List of objects in your cart
        
        //And finally, ShoppingCart has a TotalCost method that returns the cost of all the objects in your cart

        //Do not have the List in ShoppingCart be a List<object>
        
        //You need to find a way to create any number of different objects that can go in to the cart but still work with
        //the AddItem, ScanItem, and TotalCost methods of ShoppingCart

        //For running the program, you should be able to create a List of objects that you want to add to your cart
        //Then create an instance of your ShoppingCart class
        //Use a foreach loop to go through the List of things to add to your cart
        // Inside the loop call ScanItem and AddItem for each thing you are trying to add

        //After all things have been added, capture the total cost of the cart and print it to screen
    }
}