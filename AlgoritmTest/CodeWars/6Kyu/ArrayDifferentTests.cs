using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.CodeWars._6Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class ArrayDifferentTests
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 2 }, new int[] { 1 },1)]
        [DataRow(new int[] { 1, 2, 2 }, new int[] { 1 }, 2)]
        [DataRow(new int[] { 1, 2, 2 }, new int[] { 2 }, 3)]
        [DataRow(new int[] { 1, 2, 2 }, new int[] { }, 4)]
        [DataRow(new int[] { }, new int[] { 1, 2 }, 5)]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, 6)]
        public void ArrayDiffTest(int[] a, int[] b, int number)
        {
            ArrayDifferent.ArrayDiff(a, b);
        }
    }
}