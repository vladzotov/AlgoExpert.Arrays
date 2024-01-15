int[] inputs = [3, 5, -4, 8, 11, 1, -1, 6];
int targetSum = 10;
var result = TwoNumberSum(inputs, targetSum);

foreach (var item in result)
{
    Console.WriteLine(item);
}


static int[] TwoNumberSum(int[] array, int targetSum)
{
    Dictionary<int, int> hash = new Dictionary<int, int>();

    for (int i = 0; i < array.Length; i++)
    {
        var neededItem = targetSum - array[i];
        if (hash.ContainsKey(neededItem))
        {
            return new int[2] { array[i], neededItem };
        }
        else
        {
            hash.Add(array[i], neededItem);
        }
    }
    return new int[0];
}
