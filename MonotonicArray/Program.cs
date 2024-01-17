using MonotonicArray;

int[] array = [-1, -5, -10, -1100, -1100, -1101, -1102, -9001];
bool result = new MonotonicArrayIssue().IsMonotonic(array);
Console.WriteLine(result);

namespace MonotonicArray
{
    public class MonotonicArrayIssue
    {
        public bool IsMonotonic(int[] array)
        {
            if (array.Length <= 1)
            {
                return true;
            }

            bool isIncreasing = false;
            bool isDecreasing = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    isDecreasing = true;
                }
                else if (array[i - 1] < array[i])
                {
                    isIncreasing = true;
                }

                if (isIncreasing && isDecreasing)
                {
                    return false;
                }
            }

            return true;
        }
    }
}