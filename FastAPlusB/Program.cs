using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/15552
/*
 There are some precautions to be taken before solving the loop problem in earnest. In other words, 
 Time can be exceeded when input or output process is slow.

 Test number is given to first row as T.
 Two intergers given by a user is in the row of T.
 Print A + B line by line.


 input example      output example
    5               2
    1 1             46
    12 34           505
    5 500           100
    40 60           2000
    1000 1000
    
 */
namespace FastAPlusB
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder abNumbers = new StringBuilder();
            for (int i = 0; i < a; i++)
            {
                string[] A = Console.ReadLine().Split();
                abNumbers.Append(int.Parse(A[0]) + int.Parse(A[1]) + "\n");
            }
        }
    }
}
