using TwoNumberSum;

namespace Tests;

[TestClass]
public class TwoNumberSumTests
{
    [TestMethod]
    public void TwoNumberSum_DefaultCase_TwoNumbersArray()
    {
        // Arrange
        int[] inputs = [3, 5, -4, 8, 11, 1, -1, 6];
        int targetSum = 10;

        // Act
        var result = TwoNumberSumIssue.TwoNumberSum(inputs, targetSum);

        // Assert
        Assert.IsTrue(result.Length == 2);
        Assert.IsTrue(result.Contains(-1));
        Assert.IsTrue(result.Contains(11));
    }
}