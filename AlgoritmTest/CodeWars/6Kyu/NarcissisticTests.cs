namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass]
    public class NarcissisticTests
    {
        [TestMethod()]
        public void Narcissistic_Test()
        {
            Assert.IsTrue(Narcissistic.Narcissistic_(1));
            Assert.IsTrue(Narcissistic.Narcissistic_(371));
        }
    }
}