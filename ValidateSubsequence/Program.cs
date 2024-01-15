using ValidateSubsequence;

List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
List<int> sequence = new List<int> { 1, 6, -1, 10 };

var result = ValidateSubsequenceIssue.IsValidSubsequence(array, sequence);

Console.WriteLine(result);

namespace ValidateSubsequence
{
    public static class ValidateSubsequenceIssue
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int positionInSequence = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (sequence[positionInSequence] == array[i])
                {
                    positionInSequence++;
                }

                if (positionInSequence == sequence.Count)
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}