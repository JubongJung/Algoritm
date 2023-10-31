namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class DetectPangramTests
    {
        [TestMethod()]
        [DataRow("The quick brown fox jumps over the lazy dog.!@#", true)]
        public void IsPangramTest(string str, bool expect)
        {
            Assert.AreEqual(expect, DetectPangram.IsPangram(str));
        }
    }
}