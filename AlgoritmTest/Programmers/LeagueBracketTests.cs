using Algoritm.Programmers;

namespace AlgoritmTest.Programmers
{
    [TestClass()]
    public class LeagueBracketTests
    {
        [TestMethod()]
        [DataRow(8, 4, 7, 3)]
        [DataRow(8, 7, 4, 3)]
        public void solutionTest(int n, int a, int b, int answer)
        {
            LeagueBracket leagueBracket = new LeagueBracket();
            Assert.AreEqual(answer, leagueBracket.solution(n, a, b));
        }
    }
}