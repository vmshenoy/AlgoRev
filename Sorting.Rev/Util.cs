using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Rev
{
    public static class Util
    {
        public static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.Write("\n");
        }

        public static void Print(int[] arr, int lowIndx, int highIndx)
        {
            for (int i = lowIndx; i <= highIndx; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.Write("\n");
        }

        public static void SwapArrEle(int[] arr, int a, int b)
        {
            if (arr.Length < 2)//array empty or contains a single ele
            {
                throw new ArgumentException();
            }

            if (a >= arr.Length || b >= arr.Length || a < 0 || b < 0)//elements are not present in array
            {
                throw new ArgumentOutOfRangeException();
            }

            //swap ele
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
