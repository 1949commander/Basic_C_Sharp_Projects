using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stings_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetingState = "Hello my name is: ";
            string firstName = "Brian";
            string lastName = "Reeves";
            string name = greetingState + firstName +" " + lastName;
            Console.WriteLine(name);
            string name2 = string.Concat(greetingState, firstName," ", lastName);
            Console.WriteLine(name2);
            Console.WriteLine(firstName.ToUpper());   // All CAPS
            Console.WriteLine(lastName.ToLower());   // All lower case
            Console.WriteLine("The length of the txt string is: " + name.Length);
            string name3 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name3);
            StringBuilder newString = new StringBuilder();
            newString.Append("My first name is " + firstName + ". \n");
            newString.Append("My last name is " + lastName + ". \n");
            newString.Append("This is string builder.");
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
