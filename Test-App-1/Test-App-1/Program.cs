using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int packageWidth = 10;
            //int packageHeight = 25;
            //bool tooBig = (packageHeight > 25 || packageWidth > 25);
            //Console.WriteLine(tooBig);
            //Console.ReadLine();
            //string firstName = "Jesse";
            //string lastName = "Johnson";
            //string socialSecurityNumber = "111-11-1111";

            //bool isAuthorized = (firstName == "Jesse" && lastName == "Johnson" && socialSecurityNumber == "111-11-1111");
            //Console.WriteLine(isAuthorized);

            //int bankAccountBalance = 500;
            //bool isInARockBand = false;
            //string name = "Jesse";

            //bool isReallyCool = (bankAccountBalance > 100000 || isInARockBand || name == "Jesse");

            //Console.WriteLine(isReallyCool);

            //bool result = (true && (true || false));
            //Console.WriteLine(result);

            int num1 = 7;
            int num2 = 12;
            int num3 = 23;
            int num4 = 14;
            int num5 = 8;
            int num6 = 5;

            bool result = (num1 > num2 && (num3 == num4 || num5 > num6));
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
