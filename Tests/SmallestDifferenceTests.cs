using SmallestDifference;

namespace Tests;

[TestClass]
public class SmallestDifferenceTests
{
    [TestMethod]
    public void SmallestDifference_DefaultCase_Array()
    {
        int[] arrayOne = [-1, 5, 10, 20, 28, 3];
        int[] arrayTwo = [26, 134, 135, 15, 17];
        int[] expected = [28, 26];

        int[] result = new SmallestDifferenceIssue().SmallestDifference(arrayOne, arrayTwo);

        Assert.IsTrue(result.Length == 2);
        Assert.IsTrue(result[0] == expected[0]);
        Assert.IsTrue(result[1] == expected[1]);
    }

    [TestMethod]
    public void SmallestDifference_LastFirst_Array()
    {
        int[] arrayOne = [-10, 0, 20, 25];
        int[] arrayTwo = [1005, 1006, 1014, 1032, 1031];
        int[] expected = [25, 1005];

        int[] result = new SmallestDifferenceIssue().SmallestDifference(arrayOne, arrayTwo);

        Assert.IsTrue(result.Length == 2);
        Assert.IsTrue(result[0] == expected[0]);
        Assert.IsTrue(result[1] == expected[1]);
    }

    [TestMethod]
    public void SmallestDifference_FirstLast_Array()
    {
        int[] arrayOne = [2, 15, 20, 25];
        int[] arrayTwo = [-1005, -1006, -1014, -1032, -1031, 7];
        int[] expected = [2, 7];

        int[] result = new SmallestDifferenceIssue().SmallestDifference(arrayOne, arrayTwo);

        Assert.IsTrue(result.Length == 2);
        Assert.IsTrue(result[0] == expected[0]);
        Assert.IsTrue(result[1] == expected[1]);
    }
}
