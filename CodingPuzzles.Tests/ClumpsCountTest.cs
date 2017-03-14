using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class ClumpsCountTest
    {
        [TestMethod]
        public void CountClumps_Return_Number_Of_Clumps()
        {
            ClumpsCount cc = new ClumpsCount();

            int[] arrayOne = { 1, 2, 2, 3, 4, 4 };
            Assert.AreEqual(2, cc.CountClumps(arrayOne));
        }
    }
}
