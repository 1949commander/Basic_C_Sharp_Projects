using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statment
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i = 0;
                while (i < 5)
                {
                    Console.WriteLine(i);
                    i++;
                }

                Console.WriteLine("Guess a number?");
                int number = Convert.ToInt32(Console.ReadLine());
                bool isGuessed = number == 12;

                do
                {
                    switch (number)
                    {
                        case 62:
                            Console.WriteLine("You guessed 62. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 29:
                            Console.WriteLine("You guessed 29. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 55:
                            Console.WriteLine("You guessed 55. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 12:
                            Console.WriteLine("You guessed 12. That is correct!.");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isGuessed);
            }
            Console.ReadLine();
        }
    }
}
