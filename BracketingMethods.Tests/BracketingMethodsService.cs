using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bisection.Services;

namespace Bisection.UnitTests.Services
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
            var result = _bisectionService.Bisect(12,16,14,0.5,5);

            Assert.AreEqual(14.8125, result, $"{result} should be 14.8125");
        }

        #region Sample_TestCode
        [DataTestMethod]
        [DataRow(12, 16, 14, 0.5, 2)]
        [DataRow(12, 16, 14, 0.5, 3)]
        [DataRow(12, 16, 14, 0.5, 4)]
        public void TestBisect_ReturnFalse(double xl, double xu, double xr, double es, int imax)
        {
            var result = _bisectionService.Bisect(xl, xu, xr, es, imax);

            Assert.AreNotEqual(xr, $"xr value should be {xr}");
        }
        #endregion
    }
}
