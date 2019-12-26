using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A word (consist of only small letters is given to the first line.
 * Print frequency of each alphabet 
 */
namespace frequencyOfAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfAlaphbet = 26;
            string st = Console.ReadLine();
            char[] ch = st.ToCharArray();
            int[] frequencyAlphabet = new int[numOfAlaphbet];

            for (int i = 0; i < numOfAlaphbet; i++)
            {
                frequencyAlphabet[i] = -1;
            }

            for (int j = 0; j < numOfAlaphbet; j++)
            {
                for (int k = 0; k < ch.Length; k++)
                {
                    if (ch[k] - 97 == j)
                    {
                        frequencyAlphabet[j]++;
                    }
                }
            }

            foreach (int frequency in frequencyAlphabet)
            {
                Console.Write($"{frequency} ");
            }
        }
    }
}
