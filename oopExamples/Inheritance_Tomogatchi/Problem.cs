namespace Inheritance_Tomogatchi
{
    public class Problem
    {
        //We want to use Inheritance to help with out video game


        //Create a base class, GameObject
        //GameObject has 2 properties: int GameObjectId and string ObjectName
        //GameObject has a constructor that takes in a string name and inside the constructor
        //   sets the ObjectName to the incoming name and the GameObjectId is a random integer
        //Finally, GameObject has a public virtual method called DoSomething that does not return anything


        //Create two classes: Pikachu and Tomogatchi, who both inherit from GameObject

        //Pikachu also has an int property called Level
        //Pikachu has a constructor that takes in a string name and an int level
        //Set the Level on Pikachu equal to the incoming level value
        //Finally, implement the DoSomething method inside of Pikachu, have it print something to the console using the ObjectName and Level

        //For Tomogatchi, it has an int property called Age with a public get and a private set 
        //Tomogatchi has a constructor that takes in a string name and int age
        //Set the Age inside of the constructor
        //Finally, implement the DoSomething method inside of Tomogatchi, print to the screen some message using the ObjectName and Age

        //Now, create an instance of GameObject, Pikachu, and Tomogatchi

        //Call the DoSomething method on each instance

        //Don't forget to have a Console.ReadLine() to be able to see your output
    }
}