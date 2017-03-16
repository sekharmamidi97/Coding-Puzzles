using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class StringMaxBlockTests
    {
        [TestMethod]
        public void String_Length_Zero_Returns_Zero()
        {
            StringMaxBlock smb = new StringMaxBlock();
            Assert.AreEqual(0, smb.MaxBlock(""));
        }

        [TestMethod]
        public void String_Length_One_Returns_One()
        {
            StringMaxBlock smb = new StringMaxBlock();
            Assert.AreEqual(1, smb.MaxBlock("a"));
        }

        [TestMethod]
        public void String_hoopla_Returns_Two()
        {
            StringMaxBlock smb = new StringMaxBlock();
            Assert.AreEqual(2, smb.MaxBlock("hoopla"));
            
        }

        [TestMethod]
        public void String_abbCCCddBBBxx_Returns_Three()
        {
            StringMaxBlock smb = new StringMaxBlock();
            Assert.AreEqual(3, smb.MaxBlock("abbCCCddBBBxx"));
        }

        [TestMethod]
        public void String_aabcdef_Returns_Two()
        {
            StringMaxBlock smb = new StringMaxBlock();
            Assert.AreEqual(2, smb.MaxBlock("aabcdef"));
        }

        [TestMethod]
        public void String_fgh_Returns_One()
        {
            StringMaxBlock smb = new StringMaxBlock();
            Assert.AreEqual(1, smb.MaxBlock("fgh"));
        }

        [TestMethod]
        public void String_ccDDDDeeff_Returns_Four()
        {
            StringMaxBlock smb = new StringMaxBlock();
            Assert.AreEqual(4, smb.MaxBlock("ccDDDDeeff"));
        }

        [TestMethod]
        public void String_zzzzzyyxwvv_Returns_Five()
        {
            StringMaxBlock smb = new StringMaxBlock();
            Assert.AreEqual(5, smb.MaxBlock("zzzzzyyxwvv"));
        }
   
    }
}
