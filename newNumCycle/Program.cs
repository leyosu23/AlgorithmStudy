using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newNumCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int number = a;
            int i = 0;
            do
            {
                number = number % 10 * 10 + (number / 10 + number) % 10;
                i++;
            } while (a != number);
            Console.WriteLine(i);
        }
    }
}
