using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/1110
/*
 * If given number is less than 10, put 0 in front of given number.
 * Add each degit of number.
 * A new number can be created by adding the number of right-most digits to the number of right-most digits obtained in front of the number of right-most digits.
 * Print the cycle where original number become by itself.
 * 
 * example
 * input    output
 * 26       -> 4
 * 55       -> 3
 */
namespace newNumCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int number = a;
            int i = 0;
            do
            {
                number = number % 10 * 10 + (number / 10 + number) % 10;
                i++;
            } while (a != number);
            Console.WriteLine(i);
        }
    }
}
