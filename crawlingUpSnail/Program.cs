using System;
//https://www.acmicpc.net/problem/2869
/*
 * A snail likes to crawl up a tree.
 * Three interger (1 ≤ B < A ≤ V ≤ 1,000,000,000) is given to the first line.
 * A snail can crawl up A meters in the morning, and fall off B meters in the midnight.
 * Print days for a snail to crawl up V meters.
 */
namespace crawlingUpSnail
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();
            string[] infoArray = info.Split(); 
            int A = int.Parse(infoArray[0]);
            int B = int.Parse(infoArray[1]);
            int V = int.Parse(infoArray[2]);

            int x;
            if ((V - B) % (A - B) == 0)
            { 
                x = (V - B) / (A - B); 
            }
            else
            { 
                x = (V - B) / (A - B) + 1; 
            }
            Console.WriteLine(x);

            // loop logic ( takes too much time)

            //int curr = 0;
            //int days = 0;

            //while (true)
            //{
            //    days++;
            //    curr += A;
            //    if (curr >= V)
            //    {
            //        Console.WriteLine(days);
            //        break;
            //    }
            //    curr -= B;
            //}
        }
    }
}
