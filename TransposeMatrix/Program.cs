using TransposeMatrix;

int[,] input = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] input2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] result = new TransposeMatrixIssue().TransposeMatrix(input);

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.Write("\n");
}

namespace TransposeMatrix
{
    public class TransposeMatrixIssue
    {
        public int[,] TransposeMatrix(int[,] matrix)
        {
            int[,] transposedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < transposedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < transposedMatrix.GetLength(1); j++)
                {
                    transposedMatrix[i, j] = matrix[j, i];
                }
            }
            return transposedMatrix;
        }
    }
}