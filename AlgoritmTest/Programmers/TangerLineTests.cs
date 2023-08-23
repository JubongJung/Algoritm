namespace Algoritm.Programmers.Tests
{
    [TestClass()]
    public class TangerLineTests
    {
        [TestMethod()]
        [DataRow(6, new int[] { 1, 3, 2, 5, 4, 5, 2, 3 }, 3)]
        [DataRow(4, new int[] { 1, 3, 2, 5, 4, 5, 2, 3 }, 2)]
        [DataRow(2, new int[] { 1, 1, 1, 1, 2, 2, 2, 3 }, 1)]
        public void solutionTest(int k, int[] tanger, int result)
        {
            TangerLine tangerLine = new TangerLine();
            Assert.AreEqual(result, tangerLine.solution(k, tanger));
        }
    }
}