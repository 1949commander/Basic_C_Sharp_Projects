using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter an interger: ");
            //int userInteger = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your number is: " + userInteger);
            //Console.ReadLine();
            MethodOne methodOne = new MethodOne();
           
            foreach (FlashCard flashcard in methodone.FlashCards);
            {
                Console.WriteLine(flashcard.ValueOne + "and" + FlashCard.ValueTwo);
            }
            Console.WriteLine(methodOne.FlashCards.Count);
            Console.ReadLine();
        }
    }
}
