using SpiralTraverse;

namespace Tests;

[TestClass]
public class SpiralTraverseTests
{
    [TestMethod]
    public void SpiralTraverse_Case1_Array()
    {
        //arrange
        int[,] array = new int[4, 4]
        {
            {1, 2, 3, 4},
            {12, 13, 14, 5},
            {11, 16, 15, 6},
            {10, 9, 8, 7}
        };
        List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        //act
        List<int> result = new SpiralTraverseIssue().SpiralTraverse(array);

        //assert
        Assert.IsTrue(expected.Count == result.Count);
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.IsTrue(expected[i] == result[i]);
        }
    }

    [TestMethod]
    public void SpiralTraverse_Case2_Array()
    {
        //arrange
        int[,] array = new int[2, 10]
        {
            {4, 2, 3, 6, 7, 8, 1, 9, 5, 10},
            {12, 19, 15, 16, 20, 18, 13, 17, 11, 14}
        };
        List<int> expected = new List<int> { 4, 2, 3, 6, 7, 8, 1, 9, 5, 10, 14, 11, 17, 13, 18, 20, 16, 15, 19, 12 };

        //act
        List<int> result = new SpiralTraverseIssue().SpiralTraverse(array);

        //assert
        Assert.IsTrue(expected.Count == result.Count);
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.IsTrue(expected[i] == result[i]);
        }
    }

    [TestMethod]
    public void SpiralTraverse_Case3_Array()
    {
        //arrange
        int[,] array = new int[3, 3]
        {
            {1, 2, 3},
            {8, 9, 4},
            {7, 6, 5}
        };
        List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //act
        List<int> result = new SpiralTraverseIssue().SpiralTraverse(array);

        //assert
        Assert.IsTrue(expected.Count == result.Count);
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.IsTrue(expected[i] == result[i]);
        }
    }

    [TestMethod]
    public void SpiralTraverse_Case4_Array()
    {
        //arrange
        int[,] array = new int[5, 3]
        {
            {1, 2, 3},
            {12, 13, 4},
            {11, 14, 5},
            {10, 15, 6},
            {9, 8, 7}
        };
        List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //act
        List<int> result = new SpiralTraverseIssue().SpiralTraverse(array);

        //assert
        Assert.IsTrue(expected.Count == result.Count);
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.IsTrue(expected[i] == result[i]);
        }
    }

    [TestMethod]
    public void SpiralTraverse_Case5_Array()
    {
        //arrange
        int[,] array = new int[1, 7]
        {
            {1, 3, 2, 5, 4, 7, 6}
        };
        List<int> expected = new List<int> { 1, 3, 2, 5, 4, 7, 6 };

        //act
        List<int> result = new SpiralTraverseIssue().SpiralTraverse(array);

        //assert
        Assert.IsTrue(expected.Count == result.Count);
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.IsTrue(expected[i] == result[i]);
        }
    }

    [TestMethod]
    public void SpiralTraverse_Case6_Array()
    {
        //arrange
        int[,] array = new int[1, 1]
        {
            {1}
        };
        List<int> expected = new List<int> { 1 };

        //act
        List<int> result = new SpiralTraverseIssue().SpiralTraverse(array);

        //assert
        Assert.IsTrue(expected.Count == result.Count);
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.IsTrue(expected[i] == result[i]);
        }
    }
}
