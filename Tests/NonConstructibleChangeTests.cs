using NonConstructibleChange;

namespace Tests;

[TestClass]
public class NonConstructibleChangeTests
{
    [TestMethod]
    public void NonConstructibleChange_DefaultCase_ReturnInteger()
    {
        //arrange
        int[] coins = [5, 7, 1, 1, 2, 3, 22];
        int expected = 20;

        //act
        int result = new NonConstructibleChangeIssue().NonConstructibleChange(coins);

        //assert
        Assert.IsTrue(expected == result);
    }

    [TestMethod]
    public void NonConstructibleChange_DefaultCase2_ReturnInteger()
    {
        //arrange
        int[] coins = [1, 2, 4];
        int expected = 8;

        //act
        int result = new NonConstructibleChangeIssue().NonConstructibleChange(coins);

        //assert
        Assert.IsTrue(expected == result);
    }

    [TestMethod]
    public void NonConstructibleChange_DefaultCase3_ReturnInteger()
    {
        //arrange
        int[] coins = [1, 2, 4, 7];
        int expected = 15;

        //act
        int result = new NonConstructibleChangeIssue().NonConstructibleChange(coins);

        //assert
        Assert.IsTrue(expected == result);
    }

    [TestMethod]
    public void NonConstructibleChange_DefaultCase4_ReturnInteger()
    {
        //arrange
        int[] coins = [1, 2, 4, 8];
        int expected = 16;

        //act
        int result = new NonConstructibleChangeIssue().NonConstructibleChange(coins);

        //assert
        Assert.IsTrue(expected == result);
    }

    [TestMethod]
    public void NonConstructibleChange_DefaultCase5_ReturnInteger()
    {
        //arrange
        int[] coins = [1, 2, 4, 9];
        int expected = 8;

        //act
        int result = new NonConstructibleChangeIssue().NonConstructibleChange(coins);

        //assert
        Assert.IsTrue(expected == result);
    }
}
