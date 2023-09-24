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
    public class NextBigNumberTests
    {
        [TestMethod()]
        [DataRow(new int[] { 2, 3, 3, 5 }, new int[] { 3, 5, 5, -1 }, 1)]
        [DataRow(new int[] { 9, 1, 5, 3, 6, 2 }, new int[] { -1, 5, 6, 6, -1, -1 }, 2)]
        public void SolutionTest(int[] numbers, int[] result, int a)
        {
            int[] answer = new NextBigNumber().Solution(numbers, result);

            StringBuilder sb = new StringBuilder();

            foreach (var num in answer)
            {
                sb.Append(num.ToString() + ",");
            }

            Console.WriteLine(sb.ToString());

            Assert.AreEqual(answer, result);
        }
    }
}