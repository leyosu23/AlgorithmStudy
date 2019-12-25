using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/1330
/* two numbers will be given ,saparate with a single blank space
*  eg) 1 2     
*  10 2
*  print > if a > b
*  print < if a < b
*  print == if a = b
*/
namespace compareNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            int A = int.Parse(a[0]);
            int B = int.Parse(a[1]);
            if (A > B)
            {
                Console.WriteLine(">");
            }
            else if (A < B)
            {
                Console.WriteLine("<");
            }
            else if (A == B)
            {
                Console.WriteLine("==");
            }
        }
    }
}
