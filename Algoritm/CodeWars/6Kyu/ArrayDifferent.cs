using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
    /// </summary>
    public class ArrayDifferent
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> result = new List<int>();
            foreach (int i in a)
            {
                if (!b.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }
    }
}
