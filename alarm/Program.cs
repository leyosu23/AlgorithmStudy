﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/2884
/*
 * Make alram 45 mins before than given time
 */
namespace alarm
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] a = Console.ReadLine().Split();
            int hour = int.Parse(a[0]);
            int min = int.Parse(a[1]);


            int newMin = min - 45;

            if (newMin < 0)
            {
                hour -= 1;
                min = 60 + newMin;
            }
            else
            {
                min = newMin;
            }

            if (hour < 0)
            {
                hour = 24 + hour;
            }

            Console.WriteLine(hour + " " + min);

            /*
            if (min < 45)
            {
                hour--;
                min += 15;
                if (hour < 0)
                {
                    hour += 24;
                    Console.WriteLine($"{hour} {min}");
                }
                else
                {
                    Console.WriteLine($"{hour} {min}");
                }
            }
            else
            {
                Console.WriteLine($"{hour} {min - 45}");
            }
            */


        }
    }
}
