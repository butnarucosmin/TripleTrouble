using Microsoft.VisualStudio.TestTools.UnitTesting;
using TripleTrouble;
using Assert = NUnit.Framework.Assert;

namespace UnitTest.TripleTrouble
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1, Kata.TripleDouble(451999277, 41177722899));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(0, Kata.TripleDouble(1222345, 12345));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(0, Kata.TripleDouble(12345, 12345));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(1, Kata.TripleDouble(666789, 12345667));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(1, Kata.TripleDouble(10560002, 100));
        }

    }
}
