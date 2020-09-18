using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[5];
            strArray[0] = "Blue";
            strArray[1] = "Red";
            strArray[2] = "Green";
            strArray[3] = "Yellow";
            strArray[4] = "Black";

            Console.WriteLine("Please select an item number between 0 and 4:");
            int sn = Convert.ToInt32(Console.ReadLine());
            if (sn <= 4)
            {
                Console.WriteLine("Your Color is: " +strArray[sn]);
            }
            else
            {
                Console.WriteLine("Try again.");
            }

            int[] numArray = { 5, 2, 10, 200, 5000, 600, 2300 };

            Console.WriteLine("Please select an item number between 0 and 6:");
            int intA = Convert.ToInt32(Console.ReadLine());
            if (intA <= 6)
            {
                Console.WriteLine("Your Number is: " + numArray[intA]);
            }
            else
            {
                Console.WriteLine("Try again.");
            }

            List<string> strList = new List<string>();
            strList.Add("Dodge");
            strList.Add("Ford");
            strList.Add("Chevy");
            strList.Add("Mazda");
            strList.Add("Toyota");
            strList.Add("Honda");

            Console.WriteLine("Please select an item number between 0 and 5:");
            int strA = Convert.ToInt32(Console.ReadLine());
            if (strA <= 5)
            {
                Console.WriteLine("Your Car is: " + strList[strA]);
            }
            else
            {
                Console.WriteLine("Try again.");
            }


            Console.ReadLine();
        }
    }
}