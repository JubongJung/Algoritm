using System.Collections.Generic;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp
    /// </summary>
    public class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach(int i in seq)
            {
                if (map.ContainsKey(i))
                {
                    map[i] += 1;
                }
                else
                {
                    map.Add(i, 1);
                }
            }

            foreach(var row in map)
            {
                if(row.Value % 2 == 1)
                {
                    return row.Key;
                }
            }


            return -1;
        }
    }
}
