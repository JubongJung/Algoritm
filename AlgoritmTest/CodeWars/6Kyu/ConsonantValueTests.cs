﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritm.CodeWars._6Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class ConsonantValueTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            string s = "mflpfrdgqdjxaeqrgzpyphsgp";

            Console.WriteLine(ConsonantValue.Solve(s));
        }
    }
}