using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenMethods.Tests
{
    [TestClass]
    public class FixedPointService_Implement
    {
        private readonly FixedPointIterationService _fixedPointService;

        public FixedPointService_Implement()
        {
            _fixedPointService = new FixedPointIterationService();
        }

        [TestMethod]
        public void TestFixedPointIteration()
        {
            var result = _fixedPointService.Fixpt(0, 1.11, 11);
            Assert.AreEqual(0.564879, result, $"{result} should be 0.564879");
        }
    }
}
