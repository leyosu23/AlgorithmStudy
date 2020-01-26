using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(10);
            }

            //int n = arr.Length - 1;
            #region bubble
            //int limit = n;
            //for (int j = 0; j < limit; j++)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            Swap(arr, i, i + 1);
            //        }
            //    }
            //    n--;
            //}
            #endregion
            #region insertion
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            #endregion

            //display
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Swap(int[] arr, int zero, int one)
        {
            int temp = arr[zero];
            arr[zero] = arr[one];
            arr[one] = temp;
        }
    }

}
