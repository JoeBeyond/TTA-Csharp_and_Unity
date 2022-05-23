using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 4)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }
            Console.ReadLine();


            string[] names = { "Joe", "Ben", "Lilly", "Laura" };

            for (int n = 0; n < names.Length; n++)
            {
                Console.WriteLine(names[n]);
            }
            Console.ReadLine();


            List<int> testScoresB = new List<int>();
            testScoresB.Add(189);
            testScoresB.Add(268);
            testScoresB.Add(397);
            testScoresB.Add(406);
            testScoresB.Add(575);

            foreach (int score in testScoresB)
            {
                if (score > 300)
                {
                    Console.WriteLine("Passing Score! " + score);
                }
            }
            Console.ReadLine();


            List<string> names2 = new List<string>() { "Chad", "Vlad", "Brad" };
            
            foreach (string nameB in names2)
            {
                Console.WriteLine(nameB);
            }
            Console.ReadLine();


            List<int> testScoresC = new List<int>() { 10, 20, 30, 40, 50 };
            List<int> passingScore = new List<int>();

            foreach (int scoreB in testScoresC)
            {
                if (scoreB < 30)
                {
                    passingScore.Add(scoreB);
                }
            }
            Console.WriteLine(passingScore.Count);
            Console.ReadLine();
        }
    }
}
