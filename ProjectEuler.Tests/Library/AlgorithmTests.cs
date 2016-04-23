using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Library;
using ProjectEuler.Library.Algorithm;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Tests.Library
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void CollatzSequenceTest()
        {
            IEnumerable<long> list = Collatz.CollatzSequence(13);
            // 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
            Assert.AreEqual(13, list.ElementAt(0));
            Assert.AreEqual(40, list.ElementAt(1));
            Assert.AreEqual(20, list.ElementAt(2));
            Assert.AreEqual(10, list.ElementAt(3));
            Assert.AreEqual(5, list.ElementAt(4));
            Assert.AreEqual(16, list.ElementAt(5));
            Assert.AreEqual(8, list.ElementAt(6));
            Assert.AreEqual(4, list.ElementAt(7));
            Assert.AreEqual(2, list.ElementAt(8));
            Assert.AreEqual(1, list.ElementAt(9));

            Assert.AreEqual(10, list.Count());
        }
    }
}
