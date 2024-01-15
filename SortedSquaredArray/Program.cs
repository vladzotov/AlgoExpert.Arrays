using SortedSquaredArray;

SortedSquaredArrayIssue issue = new SortedSquaredArrayIssue();
int[] input = [1, 2, 3, 5, 6, 8, 9];
int[] result = issue.SortedSquaredArray(input);

foreach (var item in result)
{
    Console.WriteLine(item);
}

namespace SortedSquaredArray
{
    public class SortedSquaredArrayIssue
    {
        public int[] SortedSquaredArray(int[] array)
        {
            int[] result = new int[array.Length];
            int startIndex = 0;
            int lastIndex = array.Length - 1;

            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(array[startIndex]) > Math.Abs(array[lastIndex]))
                {
                    result[i] = array[startIndex] * array[startIndex];
                    startIndex++;
                }
                else
                {
                    result[i] = array[lastIndex] * array[lastIndex];
                    lastIndex--;
                }
            }

            return result;
        }
    }
}