using System;

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
    public class QuickSort
    {
        public void Sort(int[] inputArray)
        {
            //Guard condition
            if (inputArray.Length == 0)//empty array
            {
                throw new ArgumentNullException();
            }

            if (inputArray.Length == 1)//single item array
            {
                return;
            }

            //call the quick sort function iteratively
            Sort(inputArray, 0, inputArray.Length - 1);
        }

        void Sort(int[] arr, int low, int high)
        {
            //guard condition
            if (low >= high)
                return;

            int index = Arrange(arr, low, high);
            Sort(arr, low, index - 1);
            Sort(arr, index + 1, high);
        }

        public int Arrange(int[] arr, int lower, int upper)
        {
            int start = lower;
            int pivot = arr[lower];

            while (lower < upper)
            {
                //element less than pivot
                //low < high: to handle situation when all the elements in array are less than or equal to pivot
                //In that case the value of low goes out of bound
                while (arr[lower] <= pivot && lower < upper)
                    lower++;
                //element greater than pivot                
                while (arr[upper] > pivot)
                    upper--;

                if (lower < upper)
                    Util.SwapArrEle(arr, lower, upper);
            }

            //NOTE:All the items before "high" are less than the pivot, except the pivot 
            //swap item at high with that of index 
            //if (index < high)
            Util.SwapArrEle(arr, upper, start);            

            return upper;
        }
    }
}
/*
Dry-run 
:first iteration (arr[],low:0,high:5) return the pivot_position
    while l<h:          low     high    pivot=arr[(low + high) / 2]
    5-2-3-1-8-6         0       5       3
    5-2-3-1-8-6 //move toward center till you get item less than and greater than pivot
    l     h             0       3       // if l < h Swap(arr,0,3)
    1-2-3-5-8-6         
      h   l     //end of while return 
:Seccond iteration
    first part  (arr[],low:0,high:)
*/
