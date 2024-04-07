using System;

namespace Algoritm.CodeWars._6Kyu
{
    public class DeleteNth
    {
        public static int[] Run(int[] arr, int x)
        {
            List<int> list = arr.ToList();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> result = new List<int>();

            for (int index = 0; index < list.Count; index++)
            {
                if (dict.ContainsKey(list[index]))
                {
                    dict[list[index]]++;
                }
                else
                {
                    dict.Add(list[index], 1);
                }

                if (dict[list[index]] <= x)
                {
                    result.Add(list[index]);
                };
            }

            return result.ToArray();
        }
    }
}
