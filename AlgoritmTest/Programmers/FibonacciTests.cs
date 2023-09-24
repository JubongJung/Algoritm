using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.Programmers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;

namespace AlgoritmTest.Programmers
{
    [TestClass()]
    public class FibonacciTests
    {
        [TestMethod()]
        [DataRow(3, 2)]
        [DataRow(5, 5)]
        [DataRow(100000, 5)]
        public void solutionTest(int n, int answer)
        {
            Fibonacci fibonacci = new Fibonacci();
            Assert.AreEqual(answer, fibonacci.solution(n));
        }
    }
}