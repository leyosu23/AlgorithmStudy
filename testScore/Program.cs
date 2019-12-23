using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            if (A >= 90)
            {
                Console.WriteLine("A");
            }
            else if (A >= 80)
            {
                Console.WriteLine("B");
            }
            else if (A >= 70)
            {
                Console.WriteLine("C");
            }
            else if (A >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

        }
    }
}
