using FirstDuplicateValue;

namespace Tests;

[TestClass]
public class FirstDuplicateValueTests
{
    [TestMethod]
    public void FirstDuplicateValue_DefaultCase_Number()
    {
        int[] array = [2, 1, 5, 2, 3, 3, 4];
        int expected = 2;

        int result = new FirstDuplicateValueIssue().FirstDuplicateValue(array);

        Assert.IsTrue(expected == result);
    }

    [TestMethod]
    public void FirstDuplicateValue_DefaultCase2_Number()
    {
        int[] array = [2, 1, 5, 3, 3, 2, 4];
        int expected = 3;

        int result = new FirstDuplicateValueIssue().FirstDuplicateValue(array);

        Assert.IsTrue(expected == result);
    }
}
