using System;
//https://www.acmicpc.net/problem/1978
/*
 * Number N is given in the first line ( 0 < N < 100)
 * Number of N numbers are given to next line.
 * Print Prime number.
 */
namespace primeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string nums = Console.ReadLine();
            string[] str = nums.Split();

            // number of prime numbers
            int prime = 0;
            bool isPrime = false;


            // run for loop n times
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(str[i]);
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
                        prime++;
                    }
                }
                else if (num ==2)
                {
                    prime++;
                }
            }
            

            Console.WriteLine(prime);
        }
    }
}
