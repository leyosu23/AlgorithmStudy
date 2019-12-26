using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/2941
/*
 * The Croatian alphabet could not be entered in the operating system previously.
 * For example,  ljes=njak consists of 6 alphabets (lj, e, š, nj, a, k).
 * Print the number of Croatian alphabet based on input
 * 
 * eg) ljes=njak    ->   6
 */
namespace croatiaAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            int len = ch.Length;
            for (int i = 0; i < ch.Length - 1; i++)
            {
                if (ch[i] == 'c')
                {
                    if (ch[i + 1] == '=')
                    {
                        len--;
                    }
                    if (ch[i + 1] == '-')
                    {
                        len--;
                    }
                }
                if (ch[i] == 'd')
                {
                    if (ch[i + 1] == 'z' && ch.Length - i > 2)
                    {
                        if (ch[i + 2] == '=')
                        {
                            len -= 2;
                        }

                    }
                    if (ch[i + 1] == '-')
                    {
                        len--;
                    }
                }
                if (ch[i] == 'l')
                {
                    if (ch[i + 1] == 'j')
                    {
                        len--;
                    }
                }
                if (ch[i] == 'n')
                {
                    if (ch[i + 1] == 'j')
                    {
                        len--;
                    }
                }
                if (ch[i] == 's')
                {
                    if (ch[i + 1] == '=')
                    {
                        len--;
                    }
                }
                if (ch[i] == 'z')
                {
                    if (ch[i + 1] == '=')
                    {
                        len--;
                        if (i > 0)
                        {
                            if (ch[i - 1] == 'd')
                            {
                                len++;
                            }
                        }

                    }
                }
            }
            Console.WriteLine(len);
        }
    }
}
