using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void IsVersionTrue()
        {
            string str1 = "-v";
            string str2 = "-v";
            if (str1 == str2)
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
        [TestMethod]
        public void IsSizeequal()
        {
            string str1 = "-s";
            string str2 = "-s";
            if (str1 == str2)
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void IsSizeequal2()
        {
            string str1 = "--s";
            string str2 = "--s";
            if (str1 == str2)
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void IsSizeequal3()
        {
            string str1 = "/s";
            string str2 = "/s";
            if (str1 == str2)
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void IsSizeequal4()
        {
            string str1 = "--size";
            string str2 = "--size";
            if (str1 == str2)
            {
                Assert.IsTrue(true);
            }

        }
        //deliberate made this false to test negatve test case.
        [TestMethod]
        public void IsSizeequal5()
        {
            string str1 = "-size";
            string str2 = "--size";
            if (str1 == str2)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }





    }
}
