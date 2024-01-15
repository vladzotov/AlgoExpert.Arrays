using TwoNumberSum;

int[] inputs = [3, 5, -4, 8, 11, 1, -1, 6];
int targetSum = 10;
var result = TwoNumberSumIssue.TwoNumberSum(inputs, targetSum);

foreach (var item in result)
{
    Console.WriteLine(item);
}

namespace TwoNumberSum
{
    public static class TwoNumberSumIssue
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                var neededItem = targetSum - array[i];
                if (hash.ContainsKey(neededItem))
                {
                    return [array[i], neededItem];
                }
                else
                {
                    hash.Add(array[i], neededItem);
                }
            }
            return [];
        }
    }
}