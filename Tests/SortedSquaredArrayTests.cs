using SortedSquaredArray;

namespace Tests;

[TestClass]
public class SortedSquaredArrayTests
{
    [TestMethod]
    public void SortedSquaredArray_DefaultCase_SequenceArray()
    {
        // Arrange
        int[] input = [1, 2, 3, 5, 6, 8, 9];
        int[] expected = [1, 4, 9, 25, 36, 64, 81];
        SortedSquaredArrayIssue issue = new SortedSquaredArrayIssue();

        // Act
        int[] result = issue.SortedSquaredArray(input);

        // Assert
        Assert.IsTrue(result.Length == expected.Length);
        for (int i = 0; i < result.Length; i++)
        {
            Assert.IsTrue(result[i] == expected[i]);
        }
    }
}
