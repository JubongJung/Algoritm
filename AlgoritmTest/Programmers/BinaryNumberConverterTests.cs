namespace Algoritm.Programmers.Tests
{
    [TestClass()]
    public class BinaryNumberConverterTests
    {
        [TestMethod()]
        [DataRow(new int[] { 3, 8 }, "110010101001")]
        [DataRow(new int[] { 3, 3 }, "01110")]
        [DataRow(new int[] { 4, 1 }, "1111111")]
        public void solutionTest(int[] answer, string s)
        {
            BinaryNumberConverter converter = new BinaryNumberConverter();
            var result = converter.solution(s);

            Assert.AreEqual(answer, result);
        }
    }
}