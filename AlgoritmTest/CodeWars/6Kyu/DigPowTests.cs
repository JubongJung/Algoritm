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
    public class DigPowTests
    {
        [TestMethod()]
        public void RunTest()
        {
            Assert.AreEqual(1, DigPow.Run(89, 1));
            Assert.AreEqual(-1, DigPow.Run(92, 1));
            Assert.AreEqual(51, DigPow.Run(46288, 3));
        }
    }
}