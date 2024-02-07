using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenMethods.Tests
{
    [TestClass]
    public class FixedPointTest
    {
        private readonly FixedPointIteration _fixedPoint = new();

        [TestMethod]
        public void TestFixedPointIteration()
        {
            var result = _fixedPoint.Fixpt(0, 1.11, 11);
            Assert.AreEqual(0.564879, result, $"{result} should be 0.564879");
        }
    }
}
