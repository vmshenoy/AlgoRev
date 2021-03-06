﻿using System;

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
        #region SORT-1        
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
        #endregion

        #region SORT-2
        public void Sort2(int[] inputArray)
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
            Sort2(inputArray, 0, inputArray.Length - 1);
        }

        private void Sort2(int[] arr, int left, int right)
        {
            if (right <= left) return;

            Util.Print(arr, left, right);
            int pivot = arr[left];  //first ele is picked as pivot
            int l = left, r = right;

            while (l <= r)
            {
                //find ele greater than pivot in left sub array
                while (pivot > arr[l]) l++;

                //find ele lesser than pivot in right sub array
                while (pivot < arr[r]) r--;

                //swap the above ele's in the two sub-array
                if (l <= r)
                {
                    Util.SwapArrEle(arr, l, r);                    
                    l++;//move left
                    r--;//move right
                }
            }
                        
            if (left < (l - 1))
                Sort2(arr, left, l - 1);
            if (l < right)
                Sort2(arr, l, right);
            //note:the start index for 2nd sub-array if from (l) and not (l+1)
            //This is done to handle the case pf duplicate elements occuring in the each sub-array
        }
        #endregion
    }
}

