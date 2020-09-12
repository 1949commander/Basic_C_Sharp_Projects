using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 200;
            int y = 3;
            Console.WriteLine("x=" + (x));
            Console.WriteLine("y=" + (y));
            Console.WriteLine("x + y is: " + (x + y));
            Console.WriteLine("x - y is: " + (x - y));
            Console.WriteLine("x * y is: " + (x * y));
            Console.WriteLine("x / y is: " + (x / y));
            Console.WriteLine("x / y remander is:" + (x %= y));
            bool trueOrfalse = 12 > 5;
            Console.WriteLine(trueOrfalse.ToString());
            Console.ReadLine();
        }
    }
}
