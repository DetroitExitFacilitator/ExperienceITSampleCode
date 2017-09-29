
using System.Collections.Generic;
using System;
namespace DataTypesAndVariables.Exercise1
{
    public class AccessModifiers
    {
        //Public: public is the most common modifier of all. It's widely used because when a variable is made public, it can be accessed from anywhere. It can be referenced from within the same assembly or from another that references it.
        //Private: The private modifier is also common but for different reasons. When a variable or method is declared as private, they cannot be accessed from outside the class they were declared in. The reason why private is commonly used is because there are instances where you want to restrict access to these variables or methods like for properties of a class or methods that you only want to be used from within the same class. 
        //Protected: The protected modifier is similar to Private. It's used to limit access to certain variables or methods to the class they are declared in. How it differs from Private is that when class A inherits class B, class A also can access the protected variables and methods of class B.
        //Internal: The internal modifier limits access to variables and methods to only the class that they are declared in. It also allows access from other classes that are within the same assembly. It does not allow another project to access them even if said project is referencing the assembly the internal variables have been declared in. 

        public static void Main(string[] args)
        {
            //Instantiate a new Human and attempt set the name, age, BankAccoutnNumber and SocialSecurityNumber.

            //Now, attempt to instantiate a student and set the exact same properties and see the difference.

            //Now, head over to the AccessModifier project and attempt to instantiate a Human there and note the difference.
            Console.ReadKey();
        }


        public class Student : Human
        {
            public int StudentID { get; set; }

            public Student(string name, int age, int accountNumber, string socialSecurity)
            {
                Name = name;
                // Age = age;
                BankAccountNumber = accountNumber;
                SocialSecurityNumber = socialSecurity;

            }
        }


        public class Human
        {
            public string Name { get; set; }

            private int Age { get; set; }

            protected int BankAccountNumber { get; set; }

            internal string SocialSecurityNumber { get; set; }
        }

    }
}
