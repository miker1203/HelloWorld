using System;

namespace HelloWorld
{
    class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello GitHub World!");

            // // Type your username and press enter
            // Console.WriteLine("Enter username:");

            // // Create a string variable and get user input from the keyboard and store it in the variable
            // string userName = Console.ReadLine();
            // Console.WriteLine("Enter your age:");
            // int age = Convert.ToInt32(Console.ReadLine());

            // // Print the value of the variable (userName), which will display the input value
            // Console.WriteLine("Username is: " + userName);                    
            // Console.WriteLine("Your age is: " + age);

            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
}


