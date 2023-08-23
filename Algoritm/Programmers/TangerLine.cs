using Algoritm.Utility;
using System.IO.Pipes;

namespace Algoritm.Programmers
{
    /// <summary>
    /// https://school.programmers.co.kr/learn/courses/30/lessons/138476?language=csharp
    /// </summary>
    public class TangerLine
    {
        public int solution(int k, int[] tangerine)
        {
            int answer = 0;

            Dictionary<int, int> tanger = new Dictionary<int, int>();
            
            foreach(int i in tangerine)
            {
                if (tanger.ContainsKey(i))
                {
                    tanger[i]++;
                }
                else
                {
                    tanger.Add(i, 1);
                }
            }

            int[] tangerGroup = new int[tanger.Count];

            int tmp = 0;

            foreach(var row in tanger)
            {
                tangerGroup[tmp] = row.Value;
                tmp++;
            }

            tangerGroup = Sort.BubbleSort(tangerGroup, Sort.SortOrder.Descending);

            for(int i = 0; i < tangerGroup.Length; i++)
            {
                k -= tangerGroup[i];
                answer++;
                if(k <= 0)
                {
                    break;
                }
            }

            return answer;
        }
    }
}
