using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyNumsUsed
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int totalNum = a * b * c;

            string nums = totalNum.ToString();
            char[] ch = nums.ToCharArray();
            int[] Nums = new int[10];
            for (int i = 0; i < ch.Length; i++)
            {
                Nums[ch[i] - 48]++;
            }

            foreach (int item in Nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
