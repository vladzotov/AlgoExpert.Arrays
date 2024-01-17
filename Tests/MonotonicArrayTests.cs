using MonotonicArray;

namespace Tests;

[TestClass]
public class MonotonicArrayTests
{
    [TestMethod]
    public void MonotonicArray_MonotonicDecreaseArray_True()
    {
        //arrange
        int[] array = [-1, -5, -10, -1100, -1100, -1101, -1102, -9001];
        bool expected = true;

        //act
        bool result = new MonotonicArrayIssue().IsMonotonic(array);

        //assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void MonotonicArray_MonotonicIncreaseArray_True()
    {
        //arrange
        int[] array = [-1000, -5, -2, 1, 4, 834, 1000];
        bool expected = true;

        //act
        bool result = new MonotonicArrayIssue().IsMonotonic(array);

        //assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void MonotonicArray_NonMonotonicArray_False()
    {
        //arrange
        int[] array = [-1, -5, -10, -1100, -1100, -1101, -1102, -9001, -5];
        bool expected = false;

        //act
        bool result = new MonotonicArrayIssue().IsMonotonic(array);

        //assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void MonotonicArray_EmptyArray_True()
    {
        //arrange
        int[] array = [];
        bool expected = true;

        //act
        bool result = new MonotonicArrayIssue().IsMonotonic(array);

        //assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void MonotonicArray_EOneElementArray_True()
    {
        //arrange
        int[] array = [1];
        bool expected = true;

        //act
        bool result = new MonotonicArrayIssue().IsMonotonic(array);

        //assert
        Assert.AreEqual(result, expected);
    }
}
