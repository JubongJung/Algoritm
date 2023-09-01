using System.IO.Pipes;

namespace Algoritm.Programmers
{
    /// <summary>
    /// https://school.programmers.co.kr/learn/courses/30/lessons/87390
    /// </summary>
    public class SquareArray
    {
        public int[] solution(int n, long left, long right)
        {
            int[] answer = new int[right - left + 1];

            for(long i = left; i <= right; i++)
            {
                answer[i - left] = Convert.ToInt32(GetNumber(n, i));
            }

            return answer;
        }

        public long GetNumber(int n, long index)
        {
            long line = index / n + 1; // aka start number
            long lineIndex = index % n + 1;
            
            if(lineIndex > line)
            {
                return lineIndex;
            }
            else
            {
                return line;
            }
        }
    }
}
