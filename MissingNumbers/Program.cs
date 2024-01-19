using MissingNumbers;

//[3,4,5]

//corner case
//int[] array = [3, 4, 5];

int[] array = [1, 4, 3];
//int[] result = new MissingNumbersIssue().MissingNumbers(array);
int[] result = new MissingNumbersIssue().MissingNumbersOptimal(array);

foreach (var item in result)
{
    Console.WriteLine(item);
}

namespace MissingNumbers
{
    public class MissingNumbersIssue
    {
        public int[] MissingNumbers(int[] nums)
        {
            if (nums.Length == 0)
            {
                return new int[] { 1, 2 };
            }

            int[] result = new int[2];
            Array.Sort(nums);
            int arrayPointer = nums.Length - 1;
            int resultPointer = 1;
            // need to iterate from N+2 to 1
            for (int lookingNumber = nums.Length + 2; lookingNumber > 0; lookingNumber--)
            {
                if (lookingNumber - nums[arrayPointer] != 0)
                {
                    result[resultPointer] = lookingNumber;
                    resultPointer--;
                }
                else
                {
                    if (arrayPointer > 0)
                    {
                        arrayPointer--;
                    }
                }
            }

            // Write your code here.
            return result;
        }
    
        public int[] MissingNumbersOptimal(int[] nums)
        {
            int expectedSum = 3;
            for (int i = 3; i <= nums.Length + 2; i++)
            {
                expectedSum += i;
            }

            int currentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
            }
            int needSum = expectedSum - currentSum;
            int average = needSum / 2;
            int firstPartCurrentSum = 0;
            int secondPartCurrentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= average)
                {
                    firstPartCurrentSum += nums[i];
                }
                else
                {
                    secondPartCurrentSum += nums[i];
                }
            }

            int firstPartExpectedSum = 0;
            for (int i = 1; i <= nums.Length + 2; i++)
            {
                if (i <= average)
                {
                    firstPartExpectedSum += i;
                }
            }
            int secondPartExpectedSum = expectedSum - firstPartExpectedSum;

            return new int[] {firstPartExpectedSum - firstPartCurrentSum, secondPartExpectedSum - secondPartCurrentSum};
        }
    }
}