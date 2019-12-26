using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/1152
/*
 * Print number of word based on literal given to the first line.
 * 
 * eg)
 * The Curious Case of Benjamin Button         ->    6
 */
namespace numberOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().Trim();
            int cnt = 0;

            for (int i = 0; i < str.Length; i++)
                if (str[i] == ' ' && str[i - 1] != ' ')
                    cnt++;
            Console.WriteLine(cnt + 1);
        }
    }
}
