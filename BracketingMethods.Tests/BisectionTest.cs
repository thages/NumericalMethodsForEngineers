using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BracketingMethods.Tests
{
    [TestClass]
    public class BisectionServiceTest
    {
        private readonly Bisection _bisection = new();

        [TestMethod]
        public void TestBisect_ReturnValue()
        {
            var result = _bisection.Bisect(12, 16, 0.5, 5);

            Assert.AreEqual(14.8125, result, $"{result} should be 14.8125");
        }

        #region Sample_TestCode
        [DataTestMethod]
        [DataRow(12, 16, 0.5, 2)]
        [DataRow(12, 16, 0.5, 3)]
        [DataRow(12, 16, 0.5, 4)]
        public void TestBisect_ReturnFalse(double xl, double xu, double es, int imax)
        {
            var result = _bisection.Bisect(xl, xu, es, imax);

            Assert.AreNotEqual(result, $"xr value should be {result}");
        }
        #endregion
    }
}
