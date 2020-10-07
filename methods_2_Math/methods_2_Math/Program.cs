using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_2_Math
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is:" + userNumber);

            int myNum1 = PlusMethod(8, userNumber);
            int myNum2 = MultMethod(4, userNumber);
            int myNum3 = DivMethod(15, userNumber);
            Console.WriteLine("PlusMethod: " + myNum1);
            Console.WriteLine("MultMethod: " + myNum2);
            Console.WriteLine("DivMethod: " + myNum3);
        }
    }
}
