using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_3
{
    class Program
    {
        private static bool isNumber;
        private static bool result;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int UserNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an optional interger: ");
            string UserNum2 = Console.ReadLine();
            bool result = int.TryParse(UserNum2, out var n);

            if (string.IsNullOrEmpty(UserNum2))
            {
                int myNum1 = Class1.MethodOne(UserNum1);
                Console.WriteLine("Add Integers: " + myNum1);
            }
            else result == true;
            {
                int myNum1 = Class1.MethodOne(UserNum1, n);
                Console.WriteLine("Add Integers: " + myNum1, + myNum2);
            }

            
            Console.ReadLine();
        }
    }
}
