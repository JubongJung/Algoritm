using System.Net.WebSockets;

namespace Algoritm.Programmers
{
    public class CommonMultiple
    {
        public int solution(int[] arr)
        {
            int answer = 1;
            for(int i = 0; i < arr.Length; i++)
            {
                answer = LCM(answer, arr[i]);
            }
            
            return answer;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}
