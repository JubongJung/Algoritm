using Algoritm.Programmers;

namespace AlgoritmTest.Programmers
{
    [TestClass()]
    public class 연속부분수열합의개수Tests
    {
        [TestMethod()]
        public void solutionTest()
        {
            연속부분수열합의개수 solution = new 연속부분수열합의개수();
            solution.solution(new int[] { 7, 9, 1, 1, 4 });
        }
    }
}