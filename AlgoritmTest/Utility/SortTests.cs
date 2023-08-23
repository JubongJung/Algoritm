using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.Utility.Tests
{
    [TestClass()]
    public class SortTests
    {
        [TestMethod()]
        [DataRow(new int[] {7,6,5,4,3,2,1}, new int[] {1,2,3,4,5,6,7})]
        public void BubbleSortTest(int[] arr, int[] result)
        {
            var sorted = Sort.BubbleSort(arr, Sort.SortOrder.Descending);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(sorted[i]);
            }
        }
    }
}