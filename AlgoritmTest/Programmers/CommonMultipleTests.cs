using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.Programmers;

namespace AlgoritmTest.Programmers
{
    [TestClass()]
    public class CommonMultipleTests
    {
        [TestMethod()]
        [DataRow(new int[] { 7, 14 }, 14)]
        [DataRow(new int[] { 2, 4 }, 4)]
        [DataRow(new int[] { 2, 4, 8 }, 8)]
        [DataRow(new int[] { 5, 9 }, 45)]
        public void solutionTest(int[] arr, int result)
        {
            CommonMultiple commonMultiple = new CommonMultiple();
            Assert.AreEqual(result, commonMultiple.solution(arr));
        }

        [TestMethod()]
        public void solutionTest1()
        {
            Assert.Fail();
        }
    }
}