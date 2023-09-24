using Algoritm.Programmers;

namespace AlgoritmTest.Programmers
{
    [TestClass()]
    public class SumIntArrayTests
    {
        [TestMethod()]
        [DataRow(new int[] { 7, 9, 1, 1, 4 }, 18)]
        public void solutionTest(int[] arr, int answer)
        {
            SumIntArray sumIntArray = new SumIntArray();
            Assert.AreEqual(answer, sumIntArray.solution(arr));
        }
    }
}