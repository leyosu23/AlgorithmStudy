using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/11720
/*
 * The number of numbers to be added is given as N in the first low
 * The numbers are given to second low
 * Print sum of numbers
 * 
 * input example        output example
 * 5                    15
 * 54321
 */
namespace SumOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            char[] ch = b.ToCharArray();
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                sum += ch[i] - 48;
            }
            Console.Write(sum);
        }
    }
}
