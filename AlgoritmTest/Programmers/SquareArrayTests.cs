using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace Algoritm.Programmers.Tests
{
    [TestClass()]
    public class SquareArrayTests
    {
        private static SquareArray sa = new();

        [TestMethod()]
        [DataRow(3,2,5, new int[] { 3, 2, 2, 3 })]
        [DataRow(4, 7, 14, new int[] { 4, 3, 3, 3, 4, 4, 4, 4 })]
        public void solutionTest(int n, long left, long right, int[] result)
        {
            string solution = string.Join(',', sa.solution(n, left, right));
            string expect = string.Join(',', result);

            Console.WriteLine(solution);
            Console.WriteLine(expect);
        }

        [TestMethod()]
        [DataRow(3,2,3)]
        [DataRow(4, 5, 2)]
        [DataRow(4, 6, 3)]
        [DataRow(4, 7, 4)]
        [DataRow(4, 8, 3)]
        [DataRow(4, 9, 3)]
        public void GetNumberTest(int n, long index, int result)
        {
            Assert.AreEqual(result, sa.GetNumber(n, index));
        }
    }
}