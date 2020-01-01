using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/10872
namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(Factorial(n));
            Console.WriteLine(Factorial2(n));
        }

        static int Factorial(int num)
        {
            int result = num;
            for (int i = 1; i < num; i++)
            {
                result = result * (num - i);
            }

            if (result == 0) result = 1;

            return result;
        }

        static int Factorial2(int num)
        {
            if (num == 1 || num == 0)
                return 1;
            else
                return num * Factorial2(num - 1);
        }
    }
}
