using System;
//https://www.acmicpc.net/problem/10870
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci2(n));
        }

        #region recursive
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
        #endregion
        #region loop
        static public long Fibonacci2(long n)
        {
            long one = 1;
            long two = 1;
            long result = -1;
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
        #region dynamic programming
        static long Fibonacci3(long n)
        {
            long[] f = new long[n + 1];
            long i;

            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }
        #endregion
    }
}
