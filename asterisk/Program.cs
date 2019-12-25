using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/2439
/*
 * Print astrisks lined to right side.
 
                    *
                   **
      5 ->        ***
                 ****
                *****
 */
namespace asterisk
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cout = int.Parse(Console.ReadLine());
            //for (int i = 0; i < cout; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            int cout = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cout; i++)
            {
                for (int j = cout; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
