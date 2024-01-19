using FirstDuplicateValue;

int[] array = { 2, 1, 5, 2, 3, 3, 4 };
int result = new FirstDuplicateValueIssue().FirstDuplicateValue(array);
Console.WriteLine(result);

namespace FirstDuplicateValue
{
    public class FirstDuplicateValueIssue
    {
        public int FirstDuplicateValue(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int indexToModify = Math.Abs(array[i]) - 1;

                if (array[indexToModify] > 0)
                {
                    array[indexToModify] = array[indexToModify] * -1;
                }
                else
                {
                    return indexToModify + 1;
                }
            }

            return -1;
        }
    }
}