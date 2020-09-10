using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tech_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Create a string variable and get user input from the keyboard and store it in the variable
            
            // Type your name and press enter
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            // Type your class and press enter
            Console.WriteLine("What course are you on?");
            string yourClass = Console.ReadLine();

            // Type your Page Number and press enter
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());

            // Type True or False and press enter
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            // Enter your response
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string userComment = Console.ReadLine();

            // Enter your response            
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string userFeedback = Console.ReadLine();

            // Enter your hours
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            // End Message
            Console.WriteLine("\nThank you for your answers. \nAn Instructor will respond to this shortly. \nHave a great day!\n");

            // Print the value of the variables, which will display the input value
            Console.WriteLine("Your name is: " + yourName);
            Console.WriteLine("Your class is: " + yourClass);
            Console.WriteLine("Your page number is: " + pageNum);
            Console.WriteLine("Do you need help?: " + needHelp);
            Console.WriteLine("Your comments: " + userComment);
            Console.WriteLine("Your Feedback: " + userFeedback);
            Console.WriteLine("Your hours: " + hoursStudied);
            Console.ReadLine();
        }
    }
}