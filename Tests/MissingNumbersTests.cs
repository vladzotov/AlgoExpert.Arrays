using MissingNumbers;

namespace Tests;

[TestClass]
public class MissingNumbersTests
{
    [TestMethod]
    public void MissingNumbers_DefaulCase_Array()
    {
        int[] array = [1, 4, 3];
        int[] expected = [2, 5];

        int[] result = new MissingNumbersIssue().MissingNumbersOptimal(array);

        Assert.IsTrue(result.Length == 2);
        Assert.IsTrue(result[0] == expected[0]);
        Assert.IsTrue(result[1] == expected[1]);
    }

    [TestMethod]
    public void MissingNumbers_MissingFirstTwo_Array()
    {
        int[] array = [3, 4, 5];
        int[] expected = [1, 2];

        int[] result = new MissingNumbersIssue().MissingNumbersOptimal(array);

        Assert.IsTrue(result.Length == 2);
        Assert.IsTrue(result[0] == expected[0]);
        Assert.IsTrue(result[1] == expected[1]);
    }

    [TestMethod]
    public void MissingNumbers_EmptyArray_FirstTwoNumbers()
    {
        int[] array = [];
        int[] expected = [1, 2];

        int[] result = new MissingNumbersIssue().MissingNumbersOptimal(array);

        Assert.IsTrue(result.Length == 2);
        Assert.IsTrue(result[0] == expected[0]);
        Assert.IsTrue(result[1] == expected[1]);
    }

    [TestMethod]
    public void MissingNumbers_OneElementArray_LastTwoNumbers()
    {
        int[] array = [1];
        int[] expected = [2, 3];

        int[] result = new MissingNumbersIssue().MissingNumbersOptimal(array);

        Assert.IsTrue(result.Length == 2);
        Assert.IsTrue(result[0] == expected[0]);
        Assert.IsTrue(result[1] == expected[1]);
    }
}
