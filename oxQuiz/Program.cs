using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oxQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfQuiz = int.Parse(Console.ReadLine());
            string[] question = new string[numOfQuiz];
            for (int i = 0; i < numOfQuiz; i++)
            {
                question[i] = Console.ReadLine();
                char[] ch = question[i].ToCharArray();
                int finalScore = 0;
                int accuScore = 0;

                for (int ii = 0; ii < ch.Length; ii++)
                {
                    if (ch[ii] == 'O')
                    {
                        accuScore++;
                        finalScore += accuScore;
                    }
                    else
                    {
                        accuScore = 0;
                    }
                }
                Console.WriteLine(finalScore);
            }

        }
    }
}
