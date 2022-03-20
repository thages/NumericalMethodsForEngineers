using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BracketingMethods.Tests
{
    [TestClass]
    public class BisectionService_Implement
    {
        private readonly BisectionServices _bisectionService;

        public BisectionService_Implement()
        {
            _bisectionService = new BisectionServices();
        }

        [TestMethod]
        public void TestBisect_ReturnValue()
        {
            var result = _bisectionService.Bisect(12, 16, 0.5, 5);

            Assert.AreEqual(14.8125, result, $"{result} should be 14.8125");
        }

        #region Sample_TestCode
        [DataTestMethod]
        [DataRow(12, 16, 0.5, 2)]
        [DataRow(12, 16, 0.5, 3)]
        [DataRow(12, 16, 0.5, 4)]
        public void TestBisect_ReturnFalse(double xl, double xu, double es, int imax)
        {
            var result = _bisectionService.Bisect(xl, xu, es, imax);

            Assert.AreNotEqual(result, $"xr value should be {result}");
        }
        #endregion
    }

    [TestClass]
    public class FalsePositionService_Implent
    {
        private readonly FalsePositionService _falsePositionService;

        public FalsePositionService_Implent()
        {
            _falsePositionService = new FalsePositionService();
        }
        [TestMethod]
        public void TestFalsePosition_ReturnValue()
        {
            var result = _falsePositionService.ModFalsePos(0, 1.3, 0.5, 5);

            Assert.AreEqual(0.40818, result, $"{result} should be 0.40818");
        }
    }
}
