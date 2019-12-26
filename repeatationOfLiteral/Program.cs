using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/2675
/*
 * The number of tests is given to the first line as T ( 1 <= T <= 1000).
 * Each test case has repetation number followed by literal.
 * Print new literal.
 * 
 *  input example       output example
    2                   AABBBCCC
    3 ABC               /////HHHHHTTTTTPPPPP
    5 /HTP
 */
namespace repeatationOfLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < testCount; i++)
            {
                string[] testCases = Console.ReadLine().Split();
                int spellRepeatCount = int.Parse(testCases[0]);
                string testString = testCases[1];

                for (int j = 0; j < testString.Length; j++)
                {
                    output.Append(testString[j], spellRepeatCount);
                }

                output.Append("\n");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
