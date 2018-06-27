using System;
using System.Collections.Generic;

namespace Sorting.Rev
{
    /// <summary>
    /// Its a recursive algo
    /// In each step we select a pivot (first or random element of array)
    /// Traverse the array and copt items "less than" pivot to left & "greater that equals" to right
    /// While travesing move one pointer for left other from right till we find element greater & less than pivot
    /// Then swap them
    /// The pivot is placed at its sorted position
    /// Then we repeat the above process for the left and right sub-array seperately
    /// Time:O(nlogn) Worst:0(n^2)
    /// Space:1
    /// </summary>
    public class QuickSort2
    {
        public void Sort(int[] inputArray)
        {
            Sort(new List<int>(inputArray)).CopyTo(inputArray, 0);
        }

        List<int> Sort(List<int> arr)
        {
            if (arr.Count < 2)
                return arr;

            //guard Condition
            List<int> equal = new List<int>();
            List<int> less = new List<int>();
            List<int> more = new List<int>();
            int pivot = arr[0];

            foreach (var item in arr)
            {
                if (item == pivot)
                {
                    equal.Add(item);
                }
                else if (item < pivot)
                {
                    less.Add(item);
                }
                else
                {
                    more.Add(item);
                }
            }

            arr.Clear();
            if (less.Count > 1)
                arr.AddRange(Sort(less));
            else
                arr.AddRange(less);

            arr.AddRange(equal);

            if (more.Count > 1)
                arr.AddRange(Sort(more));
            else
                arr.AddRange(more);

            return arr;
        }
    }
}