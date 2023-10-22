namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class BreakCamelCaseTests
    {
        [TestMethod()]
        public void _BreakCamelCaseTest()
        {
            var test = new BreakCamelCase();

            Assert.AreEqual("camel Casing", test._BreakCamelCase("camelCasing"));
            Assert.AreEqual("camel Casing Test", test._BreakCamelCase("camelCasingTest"));
        }
    }
}