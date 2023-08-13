namespace Algoritm.Programmers
{
    public class LeagueBracket
    {
        public int solution(int n, int a, int b)
        {
            int answer = 1;
            while (!(a < b ? IsLeftA(a,b) : IsLeftB(a,b)))
            {
                a = NextNumber(a);
                b = NextNumber(b);
                Console.WriteLine($"a:{a}, b:{b}, count:{answer}");
                answer++;
                if(answer == 50)
                {
                    break;
                }
            }

            return answer;
        }

        public int NextNumber(int a)
        {
            return a / 2 + a % 2;
        }

        public bool IsLeftA(int a, int b)
        {
            return a % 2 == 1 && a + 1 == b;
        }

        public bool IsLeftB(int a, int b)
        {
            return b % 2 == 1 && b + 1 == a;
        }
    }
}
