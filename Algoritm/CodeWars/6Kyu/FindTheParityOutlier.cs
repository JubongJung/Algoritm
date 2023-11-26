namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/5526fc09a1bbd946250002dc/csharp
    /// </summary>
    public class FindTheParityOutlier
    {
        public static int Find(int[] integers)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            foreach(int i in integers)
            {
                if(i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
                
                if(even.Count >= 2 && odd.Count > 0)
                {
                    return odd[0];
                }
                if(odd.Count >= 2 && even.Count > 0)
                {
                    return even[0];
                }
            }

            return -1;
        }
    }
}
