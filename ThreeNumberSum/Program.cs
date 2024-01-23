using ThreeNumberSum;

int[] array = { 12, 3, 1, 2, -6, 5, -8, 6 };
int targetSum = 0;

List<int[]> result = new ThreeNumberSumIssue().ThreeNumberSum(array, targetSum);
foreach (var item in result)
{
    foreach (var number in item)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}

namespace ThreeNumberSum
{
    public class ThreeNumberSumIssue
    {
        public List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            List<int[]> result = new List<int[]>();

            Array.Sort(array);

            for (int i = 0; i < array.Length - 2; i++)
            {
                int leftPointer = i + 1;
                int rightPointer = array.Length - 1;

                while (leftPointer < rightPointer)
                {
                    int currentItem = array[i];
                    int leftItem = array[leftPointer];
                    int rightItem = array[rightPointer];

                    int currentSum = currentItem + leftItem + rightItem;
                    if (currentSum == targetSum)
                    {
                        result.Add(new int[] { currentItem, leftItem, rightItem });
                        leftPointer++;
                        rightPointer--;
                    }
                    else if (currentSum < targetSum)
                    {
                        leftPointer++;
                    }
                    else if (currentSum > targetSum)
                    {
                        rightPointer--;
                    }
                }
            }

            return result;
        }
    }
}