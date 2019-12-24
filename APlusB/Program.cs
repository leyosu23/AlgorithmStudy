using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APlusB
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string[] A = Console.ReadLine().Split();
                Console.WriteLine(int.Parse(A[0]) + int.Parse(A[1]));
            }
        }
    }
}
