using System.Collections.Generic;

namespace Algoritm.Programmers
{
    public class NextBigNumber
    {
        public int[] Solution(int[] numbers, int[] result)
        {
            int[] answer = new int[numbers.Length];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = -1;
            }

            Stack<int> stack = new Stack<int>();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0)
                {
                    stack.TryPeek(out int value);

                    if (value > numbers[i])
                    {
                        answer[i] = value;
                        break;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }

                stack.Push(numbers[i]);
            }
            return answer;
        }
    }
}
