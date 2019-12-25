using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int max = a[0];
            int min = a[0];
            for (int i = 0; i < size; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
                if (min > a[i])
                {
                    min = a[i];
                }
            }

            Console.WriteLine($"{min} {max}");
        }
    }
}
