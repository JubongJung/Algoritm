using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.CodeWars._6Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class ConvertStringToCamelCaseTests
    {
        [TestMethod()]
        [DataRow("the_stealth_warrior", "theStealthWarrior")]
        [DataRow("The-Stealth-Warrior", "TheStealthWarrior")]
        public void ToCamelCaseTest(string value, string result)
        {
            Assert.AreEqual(result, ConvertStringToCamelCase.ToCamelCase(value));
        }
    }
}