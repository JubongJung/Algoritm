using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.Programmers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.Programmers.Tests
{
    [TestClass()]
    public class HIndexTests
    {
        [TestMethod()]
        public void solutionTest()
        {
            HIndex hIndex = new HIndex();
            Console.WriteLine(hIndex.solution(new int[] { 25, 8, 5, 3, 3 }));
        }
    }
}