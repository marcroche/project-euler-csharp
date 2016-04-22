using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Library;
using System.Linq;

namespace ProjectEuler.Tests.Library
{
    [TestClass]
    public class ArithmeticTest
    {
        [TestMethod]
        public void GetDiviorsTest()
        {
            Assert.IsTrue(Arithmetic.GetDivisors(28).Count() == 6);
        }
    }
}
