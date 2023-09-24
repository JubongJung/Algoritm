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
    public class TickTackToeTests
    {
        [TestMethod()]
        [DataRow(new string[3] { "...", ".X.", "..." }, 0, 1)]
        [DataRow(new string[3] { "...", "...", "..." }, 1, 2)]
        [DataRow(new string[3] { "O.X", ".O.", "..X" }, 1, 3)]
        [DataRow(new string[3] { "OOO", "...", "XXX" }, 0, 4)]
        [DataRow(new string[3] { "O.O", "OX.", "OXX" }, 1, 5)]
        [DataRow(new string[3] { "OXO", "XXO", "XOX" }, 0, 6)]
        [DataRow(new string[3] { "XOO", "...", "XXX" }, 0, 7)]
        public void IsTickTackToeTest(string[] board, int answer, int number)
        {
            TickTackToe tickTackToe = new();
            Assert.AreEqual(answer, tickTackToe.IsTickTackToe(board));
        }
    }
}