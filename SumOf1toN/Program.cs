using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/8393
/*
 * n is given in the first row.
 * find sum of 1 to n
 * eg) 3  -> 6
 */
namespace SumOf1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 1)
            {
                int result = 0;
                for (int i = 1; i <= a; i++)
                {
                    result += i;
                }
                Console.WriteLine(result);
            }
            else if (a == 1)
            {
                Console.WriteLine(1);
            }


        }
    }
}
