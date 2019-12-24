using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 1)
            {
                int result = 0;
                for (int i = 1; i <= a; i++)
                {
                    result += i;
                }
                Console.WriteLine(result);
            }
            else if (a == 1)
            {
                Console.WriteLine(1);
            }


        }
    }
}
