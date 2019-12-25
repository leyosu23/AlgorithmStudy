using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theNumOfModulus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] modules = new int[42];
            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());
                modules[a % 42]++;
            }
            int count = 0;
            for (int i = 0; i < 42; i++)
            {
                if (modules[i] != 0)
                {

                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
