using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_App_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            
            Console.WriteLine("Enter Rate");
            int rateOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Rate = " + rateOne);

            Console.WriteLine("Enter whole hours worked per week: ");
            int timeOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hours = " + timeOne);

            Console.WriteLine("Person 2");

            Console.WriteLine("Enter Rate");
            int rateTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Rate = " + rateTwo);

            Console.WriteLine("Enter whole hours worked per week: ");
            int timeTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hours = " + timeTwo);

            Console.WriteLine("Annual salary of Person 1:");
            int payOne = rateOne * timeOne * 52;
            Console.WriteLine(payOne);

            Console.WriteLine("Annual salary of Person 2:");
            int payTwo = rateTwo * timeOne * 52;
            Console.WriteLine(payTwo);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compSal = payOne > payTwo;
            Console.WriteLine(compSal);

            Console.ReadLine();
        }
    }
}
