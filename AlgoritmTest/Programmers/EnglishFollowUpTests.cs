using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.Programmers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.Programmers.Tests
{
    [TestClass()]
    public class EnglishFollowUpTests
    {
        EnglishFollowUp englishFollowUp = new EnglishFollowUp();

        [TestMethod()]
        [DataRow(3, new string[] { "tank", "kick", "know", "wheel", "land", "dream", "mother", "robot", "tank" }, new int[] {3,3})]
        [DataRow(5, new string[] { "hello", "observe", "effect", "take", "either", "recognize", "encourage", "ensure", "establish", "hang", "gather", "refer", "reference", "estimate", "executive" }, new int[] {0,0})]
        [DataRow(2, new string[] { "hello", "one", "even", "never", "now", "world", "draw" }, new int[] {1,3})]
        public void solutionTest(int n, string[] words, int[] result)
        {
            var result1 = englishFollowUp.solution(n, words);

            Console.WriteLine($"[{result[0]},{result[1]}] [{result1[0]},{result1[1]}]");
            Assert.AreEqual(result, result1);
        }

        [TestMethod()]
        public void HasWordTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsBreackedTest()
        {
            Assert.Fail();
        }
    }
}