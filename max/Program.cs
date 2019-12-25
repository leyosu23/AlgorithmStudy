using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[9];
            int max = nums[0];
            int th = 0;

            for (int i = 0; i < 9; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
                if (nums[i] > max)
                {
                    max = nums[i];
                    th = i + 1;
                }
            }
            Console.WriteLine($"{max}\n{th}");
        }
    }
}
