using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Array_Sum_Greater_Than_OneHundred()
        {
            Math math = new Math();
            Assert.AreEqual(614, math.Math1(100));
        }

        [TestMethod]
        public void Array_Add_Less_Than_TwoHundred()
        {
            Math math = new Math();
            Assert.AreEqual(1100, math.Math2(200));
        }

        [TestMethod]
        public void Array_Addition_Greater_Than_ThreeHundred()
        {
            Math math = new Math();
            Assert.AreEqual(1786, math.Math3(300));
        }
        
        [TestMethod]
        public void Array_Max_Number_Less_Than_FourHundred()
        {
            Math math = new Math();
            Assert.AreEqual(5000, math.Math4(400));

        }

        [TestMethod]
        public void Array_Min_Number_Greater_Than_FiveHundred()
        {
            Math math = new Math();
            Assert.AreEqual(47, math.Math5(500));
        }
    }
}
