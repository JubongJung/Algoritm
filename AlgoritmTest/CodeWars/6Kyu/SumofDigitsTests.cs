namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class SumofDigitsTests
    {
        [TestMethod()]
        [DataRow(0,0)]
        [DataRow(10,1)]
        [DataRow(16,7)]
        [DataRow(167346,9)]
        public void DigitalRootTest(int n, int expected)
        {
            Assert.AreEqual(expected, SumofDigits.DigitalRoot(n));
        }
    }
}