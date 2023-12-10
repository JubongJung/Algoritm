using System.Text;

namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class DiamondTests
    {
        [TestMethod()]
        public void printTest()
        {
            var expected = new StringBuilder();
            expected.Append("*\n");
            Assert.AreEqual(expected.ToString(), Diamond.print(1));
        }

        [TestMethod]
        public void TestDiamond3()
        {
            var expected = new StringBuilder();
            expected.Append(" *\n");
            expected.Append("***\n");
            expected.Append(" *\n");

            Assert.AreEqual(expected.ToString(), Diamond.print(3));
        }

        [TestMethod]
        public void TestDiamond5()
        {
            var expected = new StringBuilder();
            expected.Append("  *\n");
            expected.Append(" ***\n");
            expected.Append("*****\n");
            expected.Append(" ***\n");
            expected.Append("  *\n");

            Assert.AreEqual(expected.ToString(), Diamond.print(5));
        }
    }
}