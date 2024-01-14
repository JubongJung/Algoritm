namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class MeetingTests
    {
        [TestMethod()]
        public void Meeting_Test()
        {
            Assert.AreEqual("(ARNO, ANN)(BELL, JOHN)(CORNWELL, ALEX)(DORNY, ABBA)(KERN, LEWIS)(KORN, ALEX)(META, GRACE)(SCHWARZ, VICTORIA)(STAN, MADISON)(STAN, MEGAN)(WAHL, ALEXIS)", Meeting.Meeting_("Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:STAN;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn"));
        }
    }
}