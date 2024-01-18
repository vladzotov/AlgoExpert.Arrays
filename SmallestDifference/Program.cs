using SmallestDifference;

int[] arrayOne = [-1, 5, 10, 20, 28, 3];
int[] arrayTwo = [26, 134, 135, 15, 17];

int[] result = new SmallestDifferenceIssue().SmallestDifference(arrayOne, arrayTwo);

foreach (var item in result)
{
    Console.WriteLine(item);
}

namespace SmallestDifference
{
    public class SmallestDifferenceIssue
    {
        public int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int[] result = new int[2];
            int minDifference = int.MaxValue;

            int pointerOne = 0;
            int pointerTwo = 0;

            while (pointerOne < arrayOne.Length && pointerTwo < arrayTwo.Length)
            {
                int numberOne = arrayOne[pointerOne];
                int numberTwo = arrayTwo[pointerTwo];

                if (numberOne < numberTwo)
                {
                    pointerOne++;
                }
                else if (numberOne > numberTwo)
                {
                    pointerTwo++;
                }
                else
                {
                    return new int[2] { numberOne, numberTwo };
                }

                int difference = Math.Abs(numberOne - numberTwo);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    result[0] = numberOne;
                    result[1] = numberTwo;
                }
            }

            return result;
        }
    }
}