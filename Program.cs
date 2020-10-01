using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numbers = new List<int>() { 5, 8, 22, 28 };
                Console.WriteLine("Enter a whole number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divide the two...");
                foreach (int num in numbers)
                {
                    var numberThree = numberOne / num;
                    Console.WriteLine(numberOne + " divided by " + num + " equals " + numberThree);
                }
                                          
            Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number...");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero....");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
