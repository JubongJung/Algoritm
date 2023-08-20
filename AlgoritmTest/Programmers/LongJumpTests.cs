using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.Programmers;

namespace Algoritm.Programmers.Tests
{
    [TestClass()]
    public class LongJumpTests
    {
        [TestMethod()]
        [DataRow(4,5)]
        [DataRow(3, 3)]
        public void solutionTest(int n, int result)
        {
            LongJump longJump = new LongJump();
            Assert.AreEqual(result, longJump.solution(n));
        }

        [TestMethod()]
        public void CombinationTest()
        {
            Console.WriteLine(LongJump.Combination(1, 4));
            Console.WriteLine(LongJump.Combination(1, 5));
        }
    }
}