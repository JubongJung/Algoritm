using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.Programmers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmTest.Programmers
{
    [TestClass()]
    public class SaleTests
    {
        [TestMethod()]
        [DataRow(
            new string[] { "banana", "apple", "rice", "pork", "pot" },
            new int[] { 3, 2, 2, 2, 1 },
            new string[] { "chicken", "apple", "apple", "banana", "rice", "apple", "pork", "banana", "pork", "rice", "pot", "banana", "apple", "banana" },
            3
            )]
        [DataRow(
            new string[] { "apple" },
            new int[] { 10 },
            new string[] { "banana", "banana", "banana", "banana", "banana", "banana", "banana", "banana", "banana", "banana" },
            0
            )]
        public void ShoppingListTest(string[] want, int[] number, string[] discount, int answer)
        {
            Sale sale = new Sale();
            Assert.AreEqual(answer, sale.GetResult(want, number, discount));
        }
    }
}