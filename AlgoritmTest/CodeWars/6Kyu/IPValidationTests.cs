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
    public class IPValidationTests
    {
        [TestMethod()]
        public void is_valid_IPTest()
        {
            Assert.AreEqual(true, IPValidation.IsValidIp("0.0.0.0"));
            Assert.AreEqual(true, IPValidation.IsValidIp("12.255.56.1"));
            Assert.AreEqual(true, IPValidation.IsValidIp("137.255.156.100"));

            Assert.AreEqual(false, IPValidation.IsValidIp(""));
            Assert.AreEqual(false, IPValidation.IsValidIp("abc.def.ghi.jkl"));
            Assert.AreEqual(false, IPValidation.IsValidIp("123.456.789.0"));
            Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56"));
            Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56.00"));
            Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56.7.8"));
            Assert.AreEqual(false, IPValidation.IsValidIp("12.34.256.78"));
            Assert.AreEqual(false, IPValidation.IsValidIp("1234.34.56"));
            Assert.AreEqual(false, IPValidation.IsValidIp("pr12.34.56.78"));
            Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56.78sf"));
            Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56 .1"));
            Assert.AreEqual(false, IPValidation.IsValidIp("12.34.56.-1"));
            Assert.AreEqual(false, IPValidation.IsValidIp("123.045.067.089"));
        }
    }
}