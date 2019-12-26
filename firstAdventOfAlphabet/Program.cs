using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/10809
/*
 * A word (consist of only small letters is given to the first line.
 * Print the first position for each alphabet.
 * First letter is position of 0 and second is 1.
 * If certain alphabet is not contained, print -1 for it.
 * 
 * input example    output example
 * baekjoon         1 0 -1 -1 2 -1 -1 -1 -1 4 3 -1 -1 7 5 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
 */
namespace firstAdventOfAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfAlaphbet = 26;
            string st = Console.ReadLine();
            char[] ch = st.ToCharArray();
            int[] alphabet = new int[numOfAlaphbet];

            for (int i = 0; i < numOfAlaphbet; i++)
            {
                alphabet[i] = -1;
            }

            for (int j = 0; j < numOfAlaphbet; j++)
            {
                for (int k = 0; k < ch.Length; k++)
                {
                    if (ch[k] - 97 == j && alphabet[j] == -1)
                    {
                        alphabet[j] = k;
                    }
                }
            }

            foreach (int item in alphabet)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
