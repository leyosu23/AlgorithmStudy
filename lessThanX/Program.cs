using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/10871
/*
 * N and X is given to the first row.
 * The numbers of N is given by a user.
 * Print only numbers less than X amongst the numbers
 * 
 * example input
 * 10 5
 * 1 10 4 9 2 3 8 5 7 6
 * 
 * example output
 * 1 4 2 3
 */
namespace lessThanX
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            string[] numbers = Console.ReadLine().Split();
            int max = int.Parse(a[0]);
            int specificNum = int.Parse(a[1]);
            for (int i = 0; i < max; i++)
            {
                int num = int.Parse(numbers[i]);
                if (num < specificNum)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
