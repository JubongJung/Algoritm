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
    public class ROT13Tests
    {
        [TestMethod()]
        public void Rot13Test()
        {
            Assert.AreEqual("EBG13 rknzcyr.", ROT13.Rot13("ROT13 example."));
        }
    }
}