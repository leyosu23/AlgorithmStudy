using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/1157
/*
 * A word is given to the first line.
 * Find and print a most used letter as a capital letter. 
 * If the letter is multiple, print "?".
 */
namespace mostCommonAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfAlaphbet = 26;
            string st = Console.ReadLine();
            char[] ch = st.ToUpper().ToCharArray();
            int[] frequencyAlphabet = new int[numOfAlaphbet];
            char result = 'a';
            // initialize 0 into each alphabet as a dafault
            for (int i = 0; i < numOfAlaphbet; i++)
            {
                frequencyAlphabet[i] = 0;
            }
            // increase if alphabet is
            for (int j = 0; j < numOfAlaphbet; j++)
            {
                for (int k = 0; k < ch.Length; k++)
                {
                    if (ch[k] - 65 == j)
                    {
                        frequencyAlphabet[j]++;
                    }
                }
            }

            int max = frequencyAlphabet[0];
            for (int q = 0; q < numOfAlaphbet; q++)
            {
                if (max < frequencyAlphabet[q])
                {
                    max = frequencyAlphabet[q];
                }
            }

            int overrappedStack = 0;
            for (int i = 0; i < numOfAlaphbet; i++)
            {
                if (max == frequencyAlphabet[i])
                {
                    overrappedStack++;
                    if (overrappedStack >= 2)
                    {
                        result = '?';
                    }
                    else
                    {
                        result = (char)(i + 65);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
