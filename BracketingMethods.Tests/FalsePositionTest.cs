using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BracketingMethods.Tests;

[TestClass]
public class FalsePositionTest
{
    private readonly FalsePosition _falsePosition = new();

    [TestMethod]
    public void TestFalsePosition_ReturnValue()
    {
        var result = _falsePosition.ModFalsePos(0, 1.3, 0.5, 5);

        Assert.AreEqual(0.40818, result, $"{result} should be 0.40818");
    }
}
