using System.IO.Pipes;

namespace Algoritm.Programmers
{
    public class BinaryNumberConverter
    {
        public int[] solution(string s)
        {
            int[] answer = new int[] {0,0};

            while (s != "1")
            {
                s = ToBinary(s, ref answer);
                Console.WriteLine($"result = {s}");
                answer[0]++;
            }
            

            return answer;
        }

        public string ToBinary(string s, ref int[] answer)
        {
            char[] stringToChar = s.ToCharArray();
            string removedZero = "";

            foreach (char c in stringToChar)
            {
                if (c == '1')
                {
                    removedZero += c;
                }
                else
                {
                    answer[1]++;
                }
            }

            int a = removedZero.Length;

            string result = "";

            while (a != 0)
            {
                if (a == 1)
                {
                    result = a.ToString() + result;
                    a = 0;
                    break;
                }

                int value = a / 2;
                int remain = a % 2;

                result = remain.ToString() + result;

                a = value;
            }

            return result;
        }
    }
}
