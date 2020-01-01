using System;
//https://www.acmicpc.net/problem/10870
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }

        static public int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else if (n ==0 )
            {
                return 0;
            }
            else
            {
                return Fibonacci(n-2) + Fibonacci(n-1);
            }
        }
        #region loop
        static public int Fibonacci2(int n)
        {
            int one = 1;
            int two = 1;
            int result = -1;
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 0;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {

                    result = one + two;
                    one = two;
                    two = result;
                }
            }
            
            return result;
        }
        #endregion
    }
}
