using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.Programmers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Algoritm.Programmers.Tests
{
    [TestClass()]
    public class CarpetTests
    {
        Carpet carpet = new Carpet();

        [TestMethod()]
        [DataRow(10,2,4,3)]
        [DataRow(8, 1, 3, 3)]
        [DataRow(24, 24, 8, 6)]
        public void solutionTest(int brown, int yellow, int left, int right)
        {
            int[] result = carpet.solution(brown, yellow);
            Assert.AreEqual(left, result[0]);
            Assert.AreEqual(right, result[1]);

        }

        [TestMethod()]
        public void GetCommonFactorTest()
        {
            var result = carpet.GetCommonFactor(100);
            
            foreach(var item in result)
            {
                Console.WriteLine($"{item[0]}, {item[1]}");
            }
        }
    }
}