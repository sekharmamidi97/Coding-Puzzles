using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class Less50Tests
    {
        [TestMethod]
        public void Number_45_Returns_True()
        {
            Less50 lFifty = new Less50();
            Assert.AreEqual(true, lFifty.Less50Exercise(45));
        }

        [TestMethod]
        public void Number_46_Returns_True()
        {
            Less50 lFifty = new Less50();
            Assert.AreEqual(true, lFifty.Less50Exercise(46));
        }

        [TestMethod]
        public void Number_50_Returns_False()
        {
            Less50 lFifty = new Less50();
            Assert.AreEqual(false, lFifty.Less50Exercise(50));
        }

        [TestMethod]
        public void Number_1496_Returns_True()
        {
            Less50 lFifty = new Less50();
            Assert.AreEqual(true, lFifty.Less50Exercise(1496));
        }

        [TestMethod]
        public void Number_1495_Returns_True()
        {
            Less50 lFifty = new Less50();
            Assert.AreEqual(true, lFifty.Less50Exercise(1495));
        }

        [TestMethod]
        public void Number_1500_Returns_False()
        {
            Less50 lFifty = new Less50();
            Assert.AreEqual(false, lFifty.Less50Exercise(1500));
        }

        [TestMethod]
        public void Number_250_Returns_False()
        {
            Less50 lFifty = new Less50();
            Assert.AreEqual(false, lFifty.Less50Exercise(250));
        }

        [TestMethod]
        public void Number_245_Returns_True()
        {
            Less50 lFifty = new Less50();
            Assert.AreEqual(true, lFifty.Less50Exercise(245));
        }

        [TestMethod]
        public void Number_246_Returns_True()
        {
            Less50 lFifty = new Less50();
            Assert.AreEqual(true, lFifty.Less50Exercise(246));
        }
    }
}
