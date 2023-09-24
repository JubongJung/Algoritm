using Algoritm.Programmers;

namespace AlgoritmTest.Programmers
{
    [TestClass()]
    public class TurnBracketTests
    {
        [TestMethod()]
        [DataRow("[](){}", 3)]
        [DataRow("}]()[{", 2)]
        [DataRow("[)(]", 0)]
        [DataRow("}}}", 0)]
        public void solutionTest(string s, int result)
        {
            TurnBracket bracket = new();
            Assert.AreEqual(result, bracket.solution(s));
        }

        [TestMethod()]
        [DataRow("{}[]{{}}{()}", true)]
        [DataRow("{(}[]{{}}{(}", false)]
        [DataRow("{}{{}}", true)]
        public void IsTrueBracketTest(string s, bool result)
        {
            TurnBracket bracket = new();

            Assert.AreEqual(result, bracket.IsTrueBracket(s));
        }
    }
}