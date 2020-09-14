using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_app_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            if (age <= 20)
            {
                Console.WriteLine("No you may not purchase that bottle of wine");
            }
            else
            {
                Console.WriteLine("There you go!");
            }

            int age1 = 21;
            if (age1 >= 25)
            {
                Console.WriteLine("You may rent a car");
            }
            else
            {
                Console.WriteLine("You cannot rent a car");
            }

            int num1 = 7;
            int num2 = 18;
            int num3 = 12;
            if (num2 > num1 && num3 < num2)
            {
                Console.WriteLine("The second number is larger than the others.");
            }

            if (true && true && true && true && num1 == 20)
            {
                Console.WriteLine("Everything is true!");
            }
            else
            {
                Console.WriteLine("There was a false somewhere!");
            }

            int packageWeight = 30;
            int packageLength = 20;
            if (packageWeight > 40 && packageLength > 20)
            {
                Console.WriteLine("This package is too big to ship.");
            }
            else
            {
                Console.WriteLine("Good to go!");
            }

            if (num1 < 7 || num1 ==12)
            {
                Console.WriteLine("At least one value is true.");
            }

            if (num1 == 12 || num1 ==18)
            {
                Console.WriteLine("At least one value is true.");
            }
            else
            {
                Console.WriteLine("No value is true.");
            }

            if (num1 == 12 || num1 == 18 || num1 == 20 || num1 == 7)
            {
                Console.WriteLine("Something is true.");
            }

            string role = "admin";
            if (role == "admin" || role == "administrator")
            {
                Console.WriteLine("You may have access to the entire software system.");
            }

            if (num1 < 18 && ((num1 == 7 )|| num1 == 2) && ((num1 == 8 && num1 > 20) || (num1 < 20 && num1 > 2)))
            {
                Console.WriteLine("Wow, that was confusing.");
            }

            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            {
                Console.WriteLine(result);
            }
            
            Console.ReadLine();
        }
    }
}
