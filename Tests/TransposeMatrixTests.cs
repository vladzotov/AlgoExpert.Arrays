using TransposeMatrix;

namespace Tests;

[TestClass]
public class TransposeMatrixTests
{
    [TestMethod]
    public void TransposeMatrix_DefaultCase_TransposedMatrix()
    {
        //arrange
        int[,] input = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] expected = new int[3, 3] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };

        //act
        int[,] result = new TransposeMatrixIssue().TransposeMatrix(input);

        //assert
        VerifyPositiveAssert(expected, result);
    }

    [TestMethod]
    public void TransposeMatrix_DefaultCase2_TransposedMatrix()
    {
        //arrange
        int[,] input = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] expected = new int[3, 2] { { 1, 4 }, { 2, 5 }, { 3, 6 } };

        //act
        int[,] result = new TransposeMatrixIssue().TransposeMatrix(input);

        //assert
        VerifyPositiveAssert(expected, result);
    }

    private void VerifyPositiveAssert(int[,] expected, int[,] result)
    {
        //assert
        Assert.IsTrue(expected.Length == result.Length);
        Assert.IsTrue(expected.GetLength(0) == result.GetLength(0));
        Assert.IsTrue(expected.GetLength(1) == result.GetLength(1));
        for (int i = 0; i < expected.GetLength(0); i++)
        {
            for (int j = 0; j < expected.GetLength(1); j++)
            {
                Assert.IsTrue(expected[i, j] == result[i, j]);
            }
        }
    }
}
