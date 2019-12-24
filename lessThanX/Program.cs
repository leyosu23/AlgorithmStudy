using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessThanX
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            string[] numbers = Console.ReadLine().Split();
            int max = int.Parse(a[0]);
            int specificNum = int.Parse(a[1]);
            for (int i = 0; i < max; i++)
            {
                int num = int.Parse(numbers[i]);
                if (num < specificNum)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
