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
    public class ParkingFeeTests
    {
        [TestMethod()]
        public void solutionTest()
        {
            ParkingFee parkingFee = new ParkingFee();
            parkingFee.solution(new int[] { 180, 5000, 10, 600 },
                new string[] { "05:34 5961 IN", "06:00 0000 IN", "06:34 0000 OUT", "07:59 5961 OUT", "07:59 0148 IN", "18:59 0000 IN", "19:09 0148 OUT", "22:59 5961 IN", "23:00 5961 OUT" });
        }
    }
}