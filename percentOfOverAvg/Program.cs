using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percentOfOverAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            float n = float.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                float[] scores = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
                float numOfStudent = scores[0];
                float totalScore = 0;
                float numOfstudentAbove = 0;
                float avg = 0;

                for (int ii = 1; ii <= numOfStudent; ii++)
                {
                    totalScore += scores[ii];
                }
                for (int iii = 1; iii <= numOfStudent; iii++)
                {
                    avg = totalScore / numOfStudent;
                    if (avg < scores[iii])
                    {
                        numOfstudentAbove++;
                    }
                }

                Console.WriteLine($"{numOfstudentAbove / numOfStudent * 100:f3}%");
            }


        }
    }
}
