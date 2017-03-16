using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingPuzzles.Katas;

namespace CodingPuzzles.Tests.KataTests
{
    [TestClass]
    public class KataHelloWorldTests
    {
        [TestMethod]
        public void HelloWorld_Return_String_HelloWorld()
        {
            KataHelloWorld khw = new KataHelloWorld();
            Assert.AreEqual("Hello World!", khw.HelloWorld());
        }
    }
}
