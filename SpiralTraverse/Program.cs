using SpiralTraverse;

// int[,] array = new int[4, 4]
// {
//     {1, 2, 3, 4},
//     {12, 13, 14, 5},
//     {11, 16, 15, 6},
//     {10, 9, 8, 7}
// };

// int[,] array = new int[2, 10]
// {
//     {4, 2, 3, 6, 7, 8, 1, 9, 5, 10},
//     {12, 19, 15, 16, 20, 18, 13, 17, 11, 14}
// };

// int[,] array = new int[3, 3]
// {
//     {1, 2, 3},
//     {8, 9, 4},
//     {7, 6, 5}
// };

// int[,] array = new int[5, 3]
// {
//     {1, 2, 3},
//     {12, 13, 4},
//     {11, 14, 5},
//     {10, 15, 6},
//     {9, 8, 7}
// };

int[,] array = new int[1, 7]
{
    {1, 3, 2, 5, 4, 7, 6}
};

List<int> resultList = new SpiralTraverseIssue().SpiralTraverse(array);
foreach (var item in resultList)
{
    Console.WriteLine(item);
}



namespace SpiralTraverse
{
    public class SpiralTraverseIssue
    {
        public List<int> SpiralTraverse(int[,] array)
        {
            List<int> result = new List<int>(array.Length);

            int startRow = 0;
            int startColumn = 0;
            int endRow = array.GetLength(0) - 1;
            int endColumn = array.GetLength(1) - 1;

            int currentRow = 0;
            int currentColumn = 0;
            while (startRow <= endRow && startColumn <= endColumn)
            {
                result.Add(array[currentRow, currentColumn]);

                if (currentRow == startRow && currentColumn < endColumn)
                {
                    currentColumn++;
                }
                else

                if (currentColumn == endColumn && currentRow < endRow)
                {
                    currentRow++;
                }
                else

                if (currentRow == endRow && currentColumn > startColumn)
                {
                    currentColumn--;

                    if (startRow == endRow || startColumn == endColumn)
                    {
                        break;
                    }
                }
                else

                if (currentColumn == startColumn && currentRow > startRow)
                {
                    currentRow--;

                    if (startRow == endRow || startColumn == endColumn)
                    {
                        break;
                    }
                }

                if (currentRow == startRow && currentColumn == startColumn)
                {
                    startRow++;
                    startColumn++;
                    endRow--;
                    endColumn--;

                    currentRow = startRow;
                    currentColumn = startColumn;
                }
            }

            return result;
        }
    }
}