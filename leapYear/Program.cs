using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/2753
/*
 * a year given in the first row.
 * if the year is a reaping year print 1 or if it's not print 0.
 */
namespace leapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 4 == 0 && a % 100 != 0 || a % 4 == 0 && a % 400 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
