using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.BaekJoon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.BaekJoon.Tests
{
    [TestClass()]
    public class Q1001Tests
    {
        [TestMethod("1001 문제 테스트")]
        [DataRow(2, 5, 10)]
        [DataRow(2, 2, 1)]
        [DataRow(1, 5, 5)]
        [DataRow(13, 29, 67863915)]
        public void CombinationTest(long N, long M, long answer)
        {
            // 팩토리얼 검증
            Assert.AreEqual(120, Q1001.Factorial(5));
            Assert.AreEqual(5040, Q1001.Factorial(7));

            Assert.AreEqual(answer, Q1001.Combination(N, M));
        }
    }
}