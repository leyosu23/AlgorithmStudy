using System;
//https://www.acmicpc.net/problem/2581
/*
 * Natural number M and N is given to the first line.
 * Find all of the prime number between M and N.
 * Print the sum of prime numbers in the first line
 * and minumum prime number in the following line.
 * ( m always be the small number than n or equal to n)
 */
namespace primeNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isPrime = false;
            int min = 0;

            // sum of prime numbers
            while (m <= n)
            {
                // run for loop n times
                int num = m;
                int curr = num - 1;
                if (num > 2)
                {
                    while (curr > 1)
                    {
                        isPrime = true;
                        // isPrime gets false if number has common factor
                        if (num % curr == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        curr--;
                    }

                    //check this number is prime number
                    if (isPrime)
                    {
                        if (min == 0)
                        {
                            min = m;
                        }
                        sum += m;
                    }
                }
                else if (num == 2)
                {
                    if (min == 0)
                    {
                        min = m;
                    }
                    sum += m;
                }
                m++;
            }

            if (sum == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(min);
            }
        }
    }
}
