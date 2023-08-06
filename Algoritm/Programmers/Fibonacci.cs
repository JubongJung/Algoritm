namespace Algoritm.Programmers
{
    public class Fibonacci
    {
        int[] F;

        public int solution(int n)
        {
            int answer = 0;

            F = new int[n + 1];
            F[0] = 0;
            F[1] = 1;

            answer = GetF(n);

            return answer;
        }

        public int GetF(int n)
        {
            if (n < 0) return 0;

            if (F[n] > 0) return F[n];

            F[n] = GetF(n - 1) + GetF(n - 2);

            return F[n] % 1234567;
        }
    }
}
