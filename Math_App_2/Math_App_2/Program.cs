using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value:");
            double entNum = Convert.ToDouble(Console.ReadLine());
            int myInt = 50;
            double multNumber = entNum * myInt;
            Console.WriteLine(entNum + " X " + myInt);
            Console.WriteLine("Sum Total:" + multNumber);

            Console.WriteLine("Enter a value:");
            double entNum_2 = Convert.ToDouble(Console.ReadLine());
            int myInt_2 = 25;
            double multNumber_2 = entNum_2 + myInt_2;
            Console.WriteLine(entNum_2 + " + " + myInt_2);
            Console.WriteLine("Total:" + multNumber_2);

            Console.WriteLine("Enter a value:");
            double entNum_3 = Convert.ToDouble(Console.ReadLine());
            double myInt_3 = 50;
            bool multNumber_3 = entNum_3 > myInt_3;
            Console.WriteLine(entNum_3 + " Greater than " + myInt_3);
            Console.WriteLine("True or False:" + multNumber_3);

            Console.WriteLine("Enter a value:");
            double entNum_4 = Convert.ToDouble(Console.ReadLine());
            double myInt_4 = 7;
            double multNumber_4 = entNum_4 % myInt_4;
            Console.WriteLine(entNum_4 + " Divded by " + myInt_4);
            Console.WriteLine("Remainder is :" + multNumber_4);

            Console.ReadLine();
        }
    }
}
