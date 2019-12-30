using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/2839
/*
 * A giant sugar bag is given to the first line in kg.
 * You need to devide into have two bags which are 5kg bag and 3kg bag.
 * Print minumum number of bags you need. (no extra kg has to be remained later)
 */
namespace sugarbag
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (true)
            {
                if (input % 5 == 0)
                {
                    Console.WriteLine(input / 5 + count);
                    break;
                }
                else if (input <= 0)
                {
                    Console.WriteLine(-1);
                    break;
                }
                input = input - 3;
                count++;
            }
        }
    }
}
