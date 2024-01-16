using NonConstructibleChange;

int[] coins = [5, 7, 1, 1, 2, 3, 22];
var result = new NonConstructibleChangeIssue().NonConstructibleChange(coins);
Console.WriteLine(result);

namespace NonConstructibleChange
{
    public class NonConstructibleChangeIssue
    {
        /// <summary>
        /// Each time we can create change + current coin only in case it's not bigger than current change + 1
        /// [1, 2, 4] -> can create up to 7
        /// [1, 2, 4, 7] -> can create up to 14 (because 1 + 2 + 4 is 7 and next coin 7 is not bigger than (7 + 1))
        /// [1, 2, 4, 8] -> can create up to 15 (because 1 + 2 + 4 is 7 and next coin 8 is not bigger than (7 + 1))
        /// [1, 2, 4, 9] -> can create up to 7 (because 1 + 2 + 4 is 7 and next coin 9 is bigger than (7 + 1))
        /// </summary>
        public int NonConstructibleChange(int[] coins)
        {
            int change = 0;
            Array.Sort(coins);

            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] > change + 1)
                {
                    return change + 1;
                }
                else
                {
                    change = change + coins[i];
                }
            }

            return change + 1;
        }
    }
}