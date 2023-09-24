using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.Programmers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmTest.Programmers
{
    [TestClass()]
    public class SmallestNumberTests
    {
        [TestMethod()]
        public void solutionTest()
        {
            SmallestNumber smallestNumber = new SmallestNumber();
            smallestNumber.solution(new int[0], new int[0]);
        }
    }
}