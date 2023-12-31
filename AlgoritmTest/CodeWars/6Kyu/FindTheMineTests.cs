namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class FindTheMineTests
    {
        [TestMethod()]
        public void MineLocationTest()
        {
            Assert.AreEqual(new Tuple<int, int>(0, 0), FindTheMine.MineLocation(new int[,] { { 1, 0 }, { 0, 0 } }));
            Assert.AreEqual(new Tuple<int, int>(2, 2), FindTheMine.MineLocation(new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 0 } }));
        }
    }
}