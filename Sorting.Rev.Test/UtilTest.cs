using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting.Rev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilTest
{
    [TestClass()]
    public class UtilTest
    {
        [DataTestMethod]
        [DataRow(new int[] { }, 1, 2)]
        [DataRow(new int[] { 0 }, 1, 2)]
        public void SwapArrEle_WhenEmpty_ThrowError(int[] arr, int a, int b)
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Util.SwapArrEle(arr, a, b);
            });
        }       

        [DataTestMethod]
        [DataRow(new int[] { 1, 2 }, 0, 2)]
        [DataRow(new int[] { 1, 2 }, 1, -1)]
        public void SwapArrEle_WhenIndxOutOfrange_ThrowError(int[] arr, int a, int b)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Util.SwapArrEle(arr, a, b);
            });
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 2 }, 0, 1, new int[] { 2, 1 })]
        [DataRow(new int[] { 1, 2, 3 }, 1, 2, new int[] { 1, 3, 2 })]
        public void SwapArrEle_NormalInput_SwapsArrEle(int[] arr, int a, int b, int[] res)
        {
            Util.SwapArrEle(arr, a, b);
            CollectionAssert.AreEqual(arr, res);
        }
    }
}