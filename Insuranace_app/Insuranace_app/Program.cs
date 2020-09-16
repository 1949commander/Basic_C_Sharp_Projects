using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insuranace_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age ?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? True or False");
            bool yourDui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int yourTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age = " + yourAge);
            Console.WriteLine("DUI's" + yourDui);
            Console.WriteLine("Tickets?" + yourTickets);
            bool ageTrue = yourAge > 15;
            bool tickTrue = yourTickets <= 3;
            bool qualTrue = ageTrue && tickTrue && (yourDui == false);
            Console.WriteLine("Qualified " + qualTrue);

            Console.ReadLine();

            //Console.WriteLine(true && false);     FALSE
            //Console.WriteLine(true && true);      TRUE
            //Console.WriteLine(false && false);    FALSE

            //Console.WriteLine(true || false);     TRUE
            //Console.WriteLine(true || true);      TRUE
            //Console.WriteLine(false || false);    FALSE

            //Console.WriteLine(true == false);     FALSE
            //Console.WriteLine(true == true);      TRUE
            //Console.WriteLine(false == false);    TRUE

            //Console.WriteLine(true ^ false);      TRUE
            //Console.WriteLine(true ^ true);       FALSE
            //Console.WriteLine(false ^ false);     FALSE
            //Console.ReadLine();


        }
    }
}
