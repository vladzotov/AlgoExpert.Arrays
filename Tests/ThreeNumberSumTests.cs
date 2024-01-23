using ThreeNumberSum;

namespace Tests;

[TestClass]
public class ThreeNumberSumTests
{
    [TestMethod]
    public void ThreeNumberSum_Case1_Array()
    {
        int[] array = { 12, 3, 1, 2, -6, 5, -8, 6 };
        int targetSum = 0;
        List<int[]> expectedTriplets = new List<int[]>()
        {
            new int[] { -8, 2, 6 },
            new int[] { -8, 3, 5 },
            new int[] { -6, 1, 5 }
        };

        List<int[]> result = new ThreeNumberSumIssue().ThreeNumberSum(array, targetSum);

        Assert.IsTrue(result.Count == expectedTriplets.Count);
        for (int i = 0; i < expectedTriplets.Count; i++)
        {
            for (int j = 0; j < expectedTriplets[i].Length; j++)
            {
                Assert.IsTrue(expectedTriplets[i][j] == result[i][j]);
            }
        }
    }

    [TestMethod]
    public void ThreeNumberSum_Case2_EmptyArray()
    {
        int[] array = { 1, 2, 3 };
        int targetSum = 7;
        List<int[]> expectedTriplets = new List<int[]>();

        List<int[]> result = new ThreeNumberSumIssue().ThreeNumberSum(array, targetSum);

        Assert.IsTrue(result.Count == expectedTriplets.Count);
        for (int i = 0; i < expectedTriplets.Count; i++)
        {
            for (int j = 0; j < expectedTriplets[i].Length; j++)
            {
                Assert.IsTrue(expectedTriplets[i][j] == result[i][j]);
            }
        }
    }

    [TestMethod]
    public void ThreeNumberSum_Case3_Array()
    {
        int[] array = { 1, 2, 3 };
        int targetSum = 6;
        List<int[]> expectedTriplets = new List<int[]>()
        {
            new int[] { 1, 2, 3 }
        };

        List<int[]> result = new ThreeNumberSumIssue().ThreeNumberSum(array, targetSum);

        Assert.IsTrue(result.Count == expectedTriplets.Count);
        for (int i = 0; i < expectedTriplets.Count; i++)
        {
            for (int j = 0; j < expectedTriplets[i].Length; j++)
            {
                Assert.IsTrue(expectedTriplets[i][j] == result[i][j]);
            }
        }
    }
}
