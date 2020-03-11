using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XamarinParamsBug.UnitTest
{
    [TestClass]
    public class TrimTester
    {
        // Fails: System.MissingMethodException: Method not found: 'System.String System.String.Trim(Char)'.

        [TestMethod]
        public void TestTrim()
        {
            Assert.AreEqual("foo", new StringTrimmer('-').TrimString("---foo---"));
        }

        // Passes 
        [TestMethod]
        public void TestTrimWorkaround()
        {
            Assert.AreEqual("foo", new StringTrimmer('-').TrimStringWorkaround("---foo---"));
        }

        // Passes
        [TestMethod]
        public void TestTrimSpaces()
        {
            Assert.AreEqual("foo", StringTrimmer.TrimSpaces("   foo   "));
        }
    }
}
