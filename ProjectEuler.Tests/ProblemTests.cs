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
        public void _0001_Test()
        {
            int actual = _0001.Run();
            Assert.AreEqual(233168, actual);
        }

        [Ignore]
        [TestMethod]
        public void _0002_Test()
        {
            int actual = _0002.Run();
            Assert.AreEqual(4613732, actual);
        }

        [Ignore]
        [TestMethod]
        public void _0003_Test()
        {
            long actual = _0003.Run();
            Assert.AreEqual(6857, actual);
        }

        [Ignore]
        [TestMethod]
        public void _0012_Test()
        {
            int actual = _0012.Run();
            Assert.AreEqual(76576500, actual);
        }

        [Ignore]
        [TestMethod]
        public void _0013_Test()
        {
            BigInteger actual = _0013.Run();
            BigInteger expected = BigInteger.Parse("5537376230390876637302048746832985971773659831892672");
            Assert.AreEqual(expected, actual);
        }
    }
}
