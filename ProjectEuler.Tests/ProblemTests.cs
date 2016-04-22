using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems;
using System.Numerics;

namespace ProjectEuler.Tests
{
    /// <summary>
    /// Summary description for Problems_Tests
    /// </summary>
    [TestClass]
    public class ProblemTests
    {
        [Ignore]
        [TestMethod]
        public void _001_Test()
        {
            int actual = _001.Run();
            Assert.AreEqual(233168, actual);
        }

        [Ignore]
        [TestMethod]
        public void _002_Test()
        {
            int actual = _002.Run();
            Assert.AreEqual(4613732, actual);
        }

        [Ignore]
        [TestMethod]
        public void _003_Test()
        {
            long actual = _003.Run();
            Assert.AreEqual(6857, actual);
        }

        [Ignore]
        [TestMethod]
        public void _012_Test()
        {
            int actual = _012.Run();
            Assert.AreEqual(76576500, actual);
        }

        [TestMethod]
        public void _013_Test()
        {
            BigInteger actual = _013.Run();
            Assert.AreEqual(76576500, actual);
        }
    }
}
