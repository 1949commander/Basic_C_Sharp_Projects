using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRANCHING_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight: ");
            double pakgWeight = Convert.ToDouble(Console.ReadLine());
            if (pakgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please Enter Package Height: ");
                double pakgHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter Package Width: ");
                double pakgWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter Package Length: ");
                double pakgLength = Convert.ToDouble(Console.ReadLine());
                double pakgSize = pakgHeight + pakgWidth + pakgLength;
                if (pakgSize > 50)
                {
                    Console.WriteLine("Package too Large to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    double pakgCost = (pakgHeight * pakgWidth * pakgLength * pakgWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + pakgCost);
                    Console.WriteLine("Thank you.");
                }
                    

            }
            Console.ReadLine();
        }
    }
}
