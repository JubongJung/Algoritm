using Algoritm.Utility;
using System.IO.Pipes;
using System.Xml.Linq;

namespace Algoritm.Programmers
{
    /// <summary>
    /// https://school.programmers.co.kr/learn/courses/30/lessons/131701
    /// </summary>
    public class SumIntArray
    {
        public int solution(int[] elements)
        {
            int answer = 0;
            elements = Sort.BubbleSort(elements, Sort.SortOrder.Descending);

            foreach(int element in elements)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("==========");

            Dictionary<int, int> sum = new Dictionary<int, int>();
            for(int start = 0; start < elements.Length; start++)
            {
                for(int count = 1; count <= elements.Length; count++)
                {
                    int arrangeSum = ArrangeSum(elements, start, count);

                    if (!sum.ContainsKey(arrangeSum))
                    {
                        Console.WriteLine(arrangeSum);
                        sum.Add(arrangeSum, 0);
                    }
                }
            }

            answer = sum.Count;

            return answer;
        }

        public int ArrangeSum(int[] elements, int start, int count)
        {
            int result = 0;

            for (int i = 0; i < count; i++)
            {
                int index = start + i;
                if(index > elements.Length - 1)
                {
                    index = index - elements.Length;
                }

                result += elements[index];
            }

            if(result == 14)
            {
                Console.WriteLine($"Start: {start}, Count:{count}");
            }

            return result;
        }
    }
}
