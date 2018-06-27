using System;

namespace Sorting.Rev
{
    /// <summary>
    /// In merge sort we divide the input array in middle into two sub-arrays 
    /// The sub-arrays are then recursively divide, till they contain exactly one element, and become self-sorted
    /// Then it merges the sorted sub-arrays by comparing each element with other sorted array
    /// The divide-merge process goes from left to right
    /// Time:O(nlogn)
    /// Space:O(n)
    /// ----------------------------------------------------------------------
    /// (5-3-2-4)
    /// (5-3)
    /// (5),(3)
    /// (3,5) //merge
    /// .....,(2,4)
    /// ....., (2),(4)
    /// .....,(2,4)//merge  
    /// (3,5),(2,4)//merge
    /// (2,3,4,5)
    /// </summary>
    public class MergeSort
    {
        public void Sort(int[] inputArray)
        {
            //guard_condition
            if (inputArray.Length == 0)
            {
                throw new ArgumentNullException("Empty Array1");
            }
            //call to iterative function
            int[] temp = new int[inputArray.Length];
            Sort(inputArray, temp, 0, inputArray.Length - 1);
        }

        //here low, high denote the actual index location of array
        void Sort(int[] arr, int[] temp, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                //Divide
                Sort(arr, temp, low, mid);
                Sort(arr, temp, mid + 1, high);
                //Merge
                Merge(arr, temp, low, mid, high);
            }
        }

        void Merge(int[] arr, int[] temp, int low, int mid, int high)
        {
            int arr1, arr2, count;//counter to the arrays
            arr1 = low;
            arr2 = mid + 1;
            count = low;

            //copy arr into temp, 
            //note i<=high as high is the index of the last element
            for (int i = low; i <= high; i++)
            {
                temp[i] = arr[i];
            }

            //arrange the elements in the original array
            while (arr1 <= mid && arr2 <= high)
            {
                if (temp[arr1] < temp[arr2])//we use temp array since its is not modified
                {
                    arr[count++] = temp[arr1++];
                }
                else
                {
                    arr[count++] = temp[arr2++];
                }
            }

            //moving the remaining element into the first part, as the right part is self-sorted
            int remaining = mid - arr1;
            //note:i <= remaining and arr[count + i] = temp[arr1 + i]
            for (int i = 0; i <= remaining; i++)
            {
                arr[count + i] = temp[arr1 + i];
            }
        }
    }
}
