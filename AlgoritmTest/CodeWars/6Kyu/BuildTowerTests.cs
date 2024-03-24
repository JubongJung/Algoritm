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
    public class BuildTowerTests
    {
        [TestMethod()]
        public void RunTest()
        {
            BuildTower.Run(1);
            BuildTower.Run(2);
            BuildTower.Run(3);
        }
    }
}