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
    public class EqualSidesOfAnArrayTests
    {
        [TestMethod()]
        public void FindEvenIndexTest()
        {
            Assert.AreEqual(3, EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.AreEqual(1, EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.AreEqual(-1, EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, EqualSidesOfAnArray.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
    }
}