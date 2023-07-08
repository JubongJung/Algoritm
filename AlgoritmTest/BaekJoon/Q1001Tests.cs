using System.Text;

namespace Algoritm.BaekJoon.Tests
{
    [TestClass()]
    public class Q1001Tests
    {
        [TestMethod("1001 문제 테스트")]
        [DataRow(2, 5, 10)]
        [DataRow(2, 2, 1)]
        [DataRow(1, 5, 5)]
        [DataRow(13, 29, 67863915)]
        [DataRow(5, 8, 56)]
        [DataRow(9, 22, 497420)]
        [DataRow(13, 21, 203490)]
        [DataRow(14, 19, 11628)]
        [DataRow(13, 17, 2380)]
        public void CombinationTest(long N, long M, long answer)
        {
            // 팩토리얼 검증
            Assert.AreEqual(120, Q1001.Factorial(5));
            Assert.AreEqual(5040, Q1001.Factorial(7));

            Assert.AreEqual(answer, Q1001.Combination(N, M));
        }
    }
}