using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int UserNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an optional interger: ");
            int UserNum2 = Convert.ToInt32(Console.ReadLine());
            int myNum1 = Class1.MethodOne(UserNum1, UserNum2);
            Console.WriteLine("Add Integers: " + myNum1);
            Console.ReadLine();
        }
    }
}
