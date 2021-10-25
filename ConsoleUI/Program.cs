using System;
using FrameworkLib;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Generators generator = new Generators();

            PersonModel person = new PersonModel
            {
                Prefix = "Mr.",
                FirstName = "Prateek",
                LastName = "Bansal"
            };

            string message = generator.WelcomeMessage(person.Prefix, person.LastName);

            Console.WriteLine(message);

            //if you instantiate a class (class library) in the main method of a program.cs, then remember that if you have static keyword in the method which is defined in that class would prevent access to that method in the program.cs file.


       
            Console.ReadLine();
        }
    }
}
