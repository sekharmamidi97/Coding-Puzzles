using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        [TestMethod]
        public void Animal_Rhino_Returns_Group_Crash()
        {
            AnimalGroupName agn = new AnimalGroupName();
            Assert.AreEqual("Crash", agn.AnimalGroup("rhino"));
        }

        [TestMethod]
        public void Animal_Giraffe_With_Lower_Upper_Case_Returns_Tower()
        {
            AnimalGroupName agn = new AnimalGroupName();
            Assert.AreEqual("Tower", agn.AnimalGroup("giraFFE"));

        }

        [TestMethod]
        public void Animal_Tiger_With_Lower_Upper_Returns_Group_Unknown()
        {
            AnimalGroupName agn = new AnimalGroupName();
            Assert.AreEqual("unknown", agn.AnimalGroup("TiGeR"));
        }

        [TestMethod]
        public void Animal_Crocodile_Lower_Returns_Group_Float()
        {
            AnimalGroupName agn = new AnimalGroupName();
            Assert.AreEqual("Float", agn.AnimalGroup("crocodile"));
        }

        [TestMethod]
        public void Animal_Bear_Upper_Returns_Group_Unknown()
        {
            AnimalGroupName agn = new AnimalGroupName();
            Assert.AreEqual("unknown", agn.AnimalGroup("BEAR"));
        }
    }
}
