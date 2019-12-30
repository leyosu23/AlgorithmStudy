using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/1712
/*
 * A,B,C are given to natural number in the first line
 * Standing charge (A) is required regardless of laptop sale.
 * B is variable expense per single laptop.
 * C is retail price.
 * Find break-even point.
 * If the break-even point does not exist ,then print -1.
 */
namespace breakeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cnt = 0;
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                cnt++;
                n -= cnt;
            }

            if (cnt % 2 == 0)
            {
                Console.WriteLine($"{cnt + n} / {1 + (-n)}");
            }
            else
            {
                Console.WriteLine($"{1 + (-n)} / {cnt + n}");
            }
        }
    }
}
