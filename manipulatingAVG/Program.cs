using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulatingAVG
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSubjects = int.Parse(Console.ReadLine());
            float[] scores = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
            float max = scores[0];

            //find max num
            for (int i = 0; i < numOfSubjects; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                }
            }

            //manipulate nums
            for (int i = 0; i < numOfSubjects; i++)
            {
                scores[i] = scores[i] / max * 100;
            }

            float sumOfScore = 0;

            for (int i = 0; i < numOfSubjects; i++)
            {
                sumOfScore += scores[i];
            }
            float Avg = sumOfScore / numOfSubjects;
            Console.WriteLine(Avg);
        }
    }
}
