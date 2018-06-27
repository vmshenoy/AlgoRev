using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Rev
{
    class Program
    {


        static void Main(string[] args)
        {
            List<int[]> test = new List<int[]>();
            int[] arr0 = { 12, 5, 3, 2, 58, 6, 1, 1, 2, 3, 3, 2, 2, 9, 54, 5, 6, 24, 5, 8, 89, 56, 4 };
            int[] arr1 = { 6, 2, 3, 6, 1, 8, 6 };
            int[] arr2 = { 3, 4, 2, 1, 6, 5, 7, 8, 1, 1 };
            test.Add(arr0);
            test.Add(arr1);
            test.Add(arr2);

            foreach (var arr in test)
            {
                Util.Print(arr);
                new QuickSort2().Sort(arr);
                Util.Print(arr); 
            }


            Console.Read();
        }
    }
}
