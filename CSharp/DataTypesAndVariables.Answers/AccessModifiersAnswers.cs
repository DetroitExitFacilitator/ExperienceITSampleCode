namespace DataTypesAndVariables.Answers
{
    public class AccessModifiersAnswers
    {
        public static void Main(string[] args)
        {
            //var person = new Human()
            //{
            //    Name = "Craig",
            //    Age = 300,
            //    BankAccountNumber = 45887,
            //    SocialSecurityNumber = "854 - 57 - 4785"
            //};

            //var t = new Student("sam", 27, 3243, "43");
        }
    }
    public class Student : Human
    {
        public int StudentID { get; set; }

        //public Student(string name, int age, int accountNumber, string socialSecurity)
        //{
        //    Name = name;
        //    Age = age;
        //    BankAccountNumber = accountNumber;
        //    SocialSecurityNumber = socialSecurity;

        //}
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
}
