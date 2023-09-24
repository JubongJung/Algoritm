using Algoritm.Programmers;

namespace AlgoritmTest.Programmers
{
    [TestClass()]
    public class SequenceSumTests
    {
        [TestMethod("연속된 부분 수열의 합")]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 7, new int[] { 2, 3 })]
        [DataRow(new int[] { 1, 1, 1, 2, 3, 4, 5 }, 5, new int[] { 6, 6 })]
        [DataRow(new int[] { 2, 2, 2, 2, 2 }, 6, new int[] { 0, 2 })]
        [DataRow(new int[] { 2, 2, 2, 2, 2 }, 2, new int[] { 0, 0 })]
        public void SolutionTest(int[] sequence, int k, int[] expected)
        {
            int[] answer = new SequenceSum().Solution(sequence, k, expected);

            Console.WriteLine($"[{expected[0]}, {expected[1]}] [{answer[0]}, {answer[1]}]");
            Assert.AreEqual(expected[0], answer[0]);
            Assert.AreEqual(expected[1], answer[1]);

        }
    }
}