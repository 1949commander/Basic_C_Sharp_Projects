﻿using System;
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
            //string[] vehicles = { "Car ", "Truck ", "Van ", "SUV " };

            //Console.WriteLine("Please input a color:");
            //string newString = Console.ReadLine();
            //for (int i = 0; i < vehicles.Length; i++)
            //{
            //    vehicles[i] += newString;
            //}

            //foreach (string i in vehicles)
            //{
            //    Console.WriteLine(i);
            //}
            //int a = 0;
            //while (a < 5)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}
            //int b = 0;
            //while (b <= 5)
            //{
            //    Console.WriteLine(b);
            //    b++;
            //}

            //List<string> carNames = new List<string>();
            //carNames.Add("Dodge Dart");
            //carNames.Add("Nissan Sentra");
            //carNames.Add("Ford Focus");
            //carNames.Add("Chevy Bolt");
            //carNames.Add("Toyota Corola");
            //carNames.Add("Honda Civic");
            //Console.WriteLine("Enter Name of Car:");
            //string txtSearch = Console.ReadLine();

            //foreach (var name in carNames)
            //    if (name == txtSearch)
            //    {
            //        int i = carNames.IndexOf(name);
            //        Console.WriteLine(i);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("No match try again");
            //    }

            List<string> peoplesNames = new List<string>();
            List<string> noDup = new List<string>();
            peoplesNames.Add("Joe Smith");
            peoplesNames.Add("John Jones");
            peoplesNames.Add("Jane Hellen");
            peoplesNames.Add("Nancy Smith");
            peoplesNames.Add("Mary Joplin");
            peoplesNames.Add("Joe Smith");
            peoplesNames.Add("Zack Wright");


            var query = peoplesNames.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => new { Element = y.Key, Counter = y.Count() })
              .ToList();
            Console.WriteLine(peoplesNames);



            Console.ReadLine();
        }
    }
}
