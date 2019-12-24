using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAPlusB
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder abNumbers = new StringBuilder();
            for (int i = 0; i < a; i++)
            {
                string[] A = Console.ReadLine().Split();
                abNumbers.Append(int.Parse(A[0]) + int.Parse(A[1]) + "\n");
            }
        }
    }
}
