﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/2742
/*
 * Natural number n is given to first row.
 * Print numbers which equal or less than n.
 */
namespace Print1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = int.Parse(Console.ReadLine());
            StringBuilder abNumbers = new StringBuilder();
            for (int i = 1; i <= a; i++)
            {
                abNumbers.Append(i + "\n");
            }
            Console.WriteLine(abNumbers.ToString());
            */

            // opposite 5 4 3 2 1
            int a = int.Parse(Console.ReadLine());
            StringBuilder abNumbers = new StringBuilder();
            for (int i = a; i > 0; i--)
            {
                abNumbers.Append(i + "\n");
            }
            Console.WriteLine(abNumbers.ToString());
        }

    }
}
