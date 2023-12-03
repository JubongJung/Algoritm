namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class CountTheSmileyFacesTests
    {
        [TestMethod()]
        public void CountSmileysTest()
        {
            Assert.AreEqual(4, CountTheSmileyFaces.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }));
            Assert.AreEqual(2, CountTheSmileyFaces.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }));
            Assert.AreEqual(1, CountTheSmileyFaces.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
            Assert.AreEqual(0, CountTheSmileyFaces.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }));
        }
    }
}