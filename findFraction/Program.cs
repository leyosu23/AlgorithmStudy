using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cnt = 0;
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                cnt++;
                n -= cnt;
            }

            if (cnt % 2 == 0)
            {
                Console.WriteLine($"{cnt + n}/{1 + (-n)}");
            }
            else
            {
                Console.WriteLine($"{1 + (-n)}/{cnt + n}");
            }
        }
    }
}
