using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/2292
namespace honeycombNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cnt = 0;
            n = int.Parse(Console.ReadLine());
            n--;
            while (n > 0)
            {
                n -= 6 * cnt;
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
