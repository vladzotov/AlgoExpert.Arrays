using ValidateSubsequence;

namespace Tests;

[TestClass]
public class ValidateSubsequenceTests
{
    [TestMethod]
    public void IsValidSubsequence_DefaultCase_True()
    {
        // Arrange
        List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
        List<int> sequence = new List<int> { 1, 6, -1, 10 };

        // Act
        var result = ValidateSubsequenceIssue.IsValidSubsequence(array, sequence);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsValidSubsequence_DefaultCase_False()
    {
        // Arrange
        List<int> array = new List<int> { 5, 1, 22, 25, -1, 8, 10 };
        List<int> sequence = new List<int> { 1, 6, -1, 10 };

        // Act
        var result = ValidateSubsequenceIssue.IsValidSubsequence(array, sequence);

        // Assert
        Assert.IsFalse(result);
    }
}
