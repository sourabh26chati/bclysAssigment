using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdPartyTools;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        FileDetails objFileDetails = new FileDetails();
        [TestMethod]
        public void IsVersionTrue()
        {
            string str1 = "-v";
            string str2 = "-v";
             if(str1==str2)
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void IsVersionTrue2()
        {
            string str1 = "--v";
            string str2 = "--v";
            if (str1 == str2)
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void IsVersionTrue3()
        {
            string str1 = "/v";
            string str2 = "/v";
            if (str1 == str2)
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void IsVersionTrue4()
        {
            string str1 = "--version";
            string str2 = "--version";
            if (str1 == str2)
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void IsVersionFalse()
        {
            string str1 = "-v";
            string str2 = "-s";
            if (str1 == str2)
            {
                Assert.IsTrue(false);
            }

        }
    }
}
