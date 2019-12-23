using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aString = Console.ReadLine().Split();
            int a = int.Parse(aString[0]);
            int b = int.Parse(aString[1]);
            int c = int.Parse(aString[2]);
            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    if (a > c)
                        Console.WriteLine(c);
                    else
                        Console.WriteLine(a);
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                        Console.WriteLine(a);
                    else
                        Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
