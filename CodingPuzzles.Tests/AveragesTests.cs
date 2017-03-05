using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class AveragesTests
    {
        [TestMethod]
        public void Array_Average_Less_Than_Fifty()
        {
            Averages avg = new Averages();
            Assert.AreEqual(85, avg.AverageExercise1(50));
        }

        [TestMethod]
        public void Array_Average_Less_Than_OneHundred()
        {
            Averages avg = new Averages();
            Assert.AreEqual(206, avg.AverageExercise2(100));
        }

        [TestMethod]
        public void Array_Average_Less_Than_OneHundredFifty()
        {
            Averages avg = new Averages();
            Assert.AreEqual(317, avg.AverageExercise3(150));
        }

        [TestMethod]
        public void Array_Average_Less_Than_TwoHundredSeventyFive()
        {
            Averages avg = new Averages();
            Assert.AreEqual(458, avg.AverageExercise4(275));
        }

        [TestMethod]
        public void Array_Average_Less_Than_FiveHundred()
        {
            Averages avg = new Averages();
            Assert.AreEqual(261, avg.AverageExercise5(500));
        }
    }
}
