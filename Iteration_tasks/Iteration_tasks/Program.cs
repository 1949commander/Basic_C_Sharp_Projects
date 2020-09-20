using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_tasks
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //    for(int i =  0; i < testScores.Length; i++)
        //        if (testScores[i] > 85)
        //        {
        //            Console.WriteLine("Passing test score: " + testScores[i]);
        //        }
        //    Console.ReadLine();
        //}
        {
            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 12, 88, 32, 86 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }

        
    }
}
