using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class TripleUpTests
    {
        [TestMethod]
        public void TripleUpArrayTest()
        {
            //Act
            TripleUp tu = new TripleUp();

            //Arrange
            int[] arrayOne = new int[] { 1, 2, 3 };
            int[] arrayTwo = new int[] { 23, 24, 25 };
            int[] arrayThree = new[] { 57, 58, 60 };

            //Assert
            Assert.AreEqual(true, tu.TripleUpArray(arrayOne));
            Assert.AreEqual(true, tu.TripleUpArray(arrayTwo));
            Assert.AreEqual(false, tu.TripleUpArray(arrayThree));
        }
    }
}
