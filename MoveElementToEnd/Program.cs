using MoveElementToEnd;

List<int> array = new List<int> { 2, 1, 2, 2, 2, 3, 4, 2 };
int toMove = 2;
new MoveElementToEndIssue().MoveElementToEnd(array, toMove);

foreach (var item in array)
{
    Console.WriteLine(item);
}

namespace MoveElementToEnd
{
    public class MoveElementToEndIssue
    {
        public List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            int startIndex = 0;
            int lastIndex = array.Count - 1;

            while(startIndex < lastIndex)
            {
                if (array[startIndex] == toMove)
                {
                    while(array[lastIndex] == toMove && lastIndex > startIndex)
                    {
                        lastIndex--;
                    }

                    int temp = array[lastIndex];
                    array[lastIndex] = array[startIndex];
                    array[startIndex] =  temp;
                }
                startIndex++;
            }

            return array;
        }
    }
}