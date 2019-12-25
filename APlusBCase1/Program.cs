using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/11021
/*
 * The number of test is given in the first row as T.
 * two integers ( 0 < a,b <10 ) are given in the T row ,separated with a single blank space.
 * Print A + B as a format of Case #T: A+B
 * 
 * input example
 *  5
    1 1
    2 3
    3 4
    9 8
    5 2

    output example
    Case #1: 2
    Case #2: 5
    Case #3: 7
    Case #4: 17
    Case #5: 7
 */
namespace APlusBCase1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                string[] A = Console.ReadLine().Split();
                Console.WriteLine($"Case #{i}: {int.Parse(A[0])} + {int.Parse(A[1])} = {int.Parse(A[0]) + int.Parse(A[1])}");
            }
        }
    }
}
