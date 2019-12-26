using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/2908
/*
 * A person named as Constant reads number in reverse order.
 * For example, the numbers 734 and 897 as 437 and 398 and say 437 is a bigger number.
 * In this respect, print a bigger number based on given two numbers as for the answer of Constant.
 * 
 *      input     output
 * eg ) 734 893 -> 437
 */
namespace constant
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            string[] str = nums.Split();
            int num1 = int.Parse(str[0]);
            int num2 = int.Parse(str[1]);

            int output1 = 0;
            while (num1 > 0)
            {
                int remainder = num1 % 10;
                output1 = (output1 * 10) + remainder;
                num1 = num1 / 10;
            }

            int output2 = 0;
            while (num2 > 0)
            {
                int remainder = num2 % 10;
                output2 = (output2 * 10) + remainder;
                num2 = num2 / 10;
            }

            if (output1 > output2)
            {
                Console.WriteLine(output1);
            }
            else
            {
                Console.WriteLine(output2);
            }
        }
    }
}
