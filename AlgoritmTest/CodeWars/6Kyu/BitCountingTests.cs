namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class BitCountingTests
    {
        [TestMethod()]
        public void CountBitsTest()
        {
            Assert.AreEqual(0, BitCounting.CountBits(0));
            Assert.AreEqual(1, BitCounting.CountBits(4));
            Assert.AreEqual(3, BitCounting.CountBits(7));
            Assert.AreEqual(2, BitCounting.CountBits(9));
            Assert.AreEqual(2, BitCounting.CountBits(10));
        }
    }
}