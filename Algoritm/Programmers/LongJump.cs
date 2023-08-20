namespace Algoritm.Programmers
{
    public class LongJump
    {
        public long solution(int n)
        {
            long answer = 0;

            for(int i = 0; i <= n / 2; i++)
            {
                answer += Combination(i, (n - i));
            }

            return answer;
        }

        public static long Combination(long N, long M)
        {
            if (N == 0 || M == 0) return 1;

            long son = 1;

            for (long i = M; i > M - N; i--)
            {
                son *= i;
            }

            long mother = Factorial(N);

            return son / mother;
        }

        public static long Factorial(long number)
        {
            long result = 1;

            for (long i = 1; i <= number; i++)
            {
                result = checked(result * i);
            }

            return result;
        }
    }
}
