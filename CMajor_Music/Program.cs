using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMajor_Music
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int first = nums[0];
            string state = "mixed";
            int ascendingStack = 0;
            int descendingStack = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > first)
                {
                    first = nums[i];
                    ascendingStack++;
                }
                if (nums[i] < first)
                {
                    first = nums[i];
                    descendingStack++;
                }
            }
            if (ascendingStack == 7)
            {
                state = "ascending";
            }
            if (descendingStack == 7)
            {
                state = "descending";
            }
            Console.WriteLine(state);
        }
    }
}
