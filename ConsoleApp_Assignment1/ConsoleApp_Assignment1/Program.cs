using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vehicles = { "Car", "Truck", "Van", "SUV" };

            Console.WriteLine("Please input a color:");
            string newString = Console.ReadLine();
            foreach (string i in vehicles)
            {
                Console.WriteLine(i + newString);
            }
                 Console.ReadLine();
        }
    }
}
