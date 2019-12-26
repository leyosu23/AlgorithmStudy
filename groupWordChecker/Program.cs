using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/1316
/*
 * A group word is for all characters present in a word, only if each character appears consecutively. 
 * For example, ccazzzzbb is a group word because c, a, z, and b all appear consecutively, 
 * and kin are also a group word because k, i, n appear consecutively, but abbbccb is not a group word because b appears separately.
 * Write a program that accepts N words as input and outputs the number of group words.
 * 
 * The number of words is given to the first line.
 * Then, each word is following line by line.
 * 
 *  input  example     output example
 *  3              ->       3
    happy
    new
    year


    4            ->         1
    aba
    abab
    abcabc
    a
 */
namespace groupWordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupWords = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                int[] alphabetChecker = new int[26];
                char[] chArray = word.ToCharArray();

                for (int j = 0; j < chArray.Length; j++)
                {
                    if (j > 0)
                    {
                        if (chArray[j - 1] != chArray[j])
                        {
                            alphabetChecker[chArray[j] - 97]++;
                        }
                    }
                    else
                    {
                        alphabetChecker[chArray[j] - 97]++;
                    }
                }

                bool groupWordCheck = true;
                for (int k = 0; k < 26; k++)
                {
                    if (alphabetChecker[k] > 1)
                    {
                        groupWordCheck = false;
                        break;
                    }
                }

                if (groupWordCheck)
                {
                    groupWords++;
                }
            }

            Console.WriteLine(groupWords);
        }
    }
}
