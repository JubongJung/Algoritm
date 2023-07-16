using System.Text;

namespace Algoritm.Programmers
{
    public class NextBigNumber
    {
        public int[] Solution(int[] numbers, int[] result)
        {
            int[] answer = new int[numbers.Length];
            for(int i = 0; i<answer.Length; i++)
            {
                answer[i] = -1;
            }

            for (int i =0; i < numbers.Length; i++)
            {
                if(i == numbers.Length - 1)
                {
                    break;
                }

                for(int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        answer[i] = numbers[j];
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
