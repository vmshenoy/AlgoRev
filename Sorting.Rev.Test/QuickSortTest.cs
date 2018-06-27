using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sorting.Rev.Test
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void Sort_WhenEmptyInput_ThenException()
        {
            int[] inputArray = { };
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                new QuickSort().Sort(inputArray);
            });
        }

        [DataTestMethod]
        [DataRow(new int[] { 0 }, new int[] { 0 })]
        [DataRow(new int[] { 1 }, new int[] { 1 })]
        [DataRow(new int[] { 1 }, new int[] { 1 })]
        public void Sort_WhenOneInput_ThenSortArray(int[] inputArray, int[] expectedArray)
        {
            new QuickSort().Sort(inputArray);
            CollectionAssert.AreEqual(inputArray, expectedArray);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 5, 9, 8 }, new int[] { 1, 5, 8, 9 })]
        [DataRow(new int[] { 1, 25, 9, 88, 6, 17, 3, 4, 12 }, new int[] { 1, 3, 4, 6, 9, 12, 17, 25, 88 })]
        [DataRow(new int[] { 1, 5, 9, 1, 6, 1, 3, 4, 2 }, new int[] { 1, 1, 1, 2, 3, 4, 5, 6, 9 })]
        public void Sort_WhenNormalInput_ThenSortedArray(int[] inputArray, int[] expectedArray)
        {
            new QuickSort().Sort(inputArray);
            CollectionAssert.AreEqual(inputArray, expectedArray);
        }
    }
}
