using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            int myNum1 = Class1.PlusMethod(8, 9);
            Console.WriteLine("Add Intergers: " + myNum1);

            double myNum2 = Class1.PlusMethod(2.3, 3.5);
            Console.WriteLine("Multiply Decimal: " + myNum2);
            

            int myNum3 = Class1.PlusMethod(2 , 3);
            Console.WriteLine("Multiply Decimal: " + myNum3);
            Console.ReadLine();

        }
    }
}
