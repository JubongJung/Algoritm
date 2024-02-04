namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/59c633e7dcc4053512000073/csharp
    /// </summary>
    public class HighestRankNumberinanArray
    {
        public static int HighestRank(int[] arr)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            foreach(int i in arr)
            {
                if (keyValuePairs.ContainsKey(i))
                {
                    keyValuePairs[i] += 1;
                }
                else
                {
                    keyValuePairs.Add(i, 1);
                }
            }

            return keyValuePairs.OrderByDescending(x => x.Value).ThenByDescending(x=>x.Key).First().Key;
        }
    }
}
