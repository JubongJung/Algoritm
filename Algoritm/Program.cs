namespace Algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            long.TryParse(Console.ReadLine(), out long maxT);
            long[] a = new long[maxT];
            long[] b = new long[maxT];

            for (long i = 0; i < maxT; i++)
            {
                string[] ab = Console.ReadLine().Split(' ');
                a[i] = long.Parse(ab[0]);
                b[i] = long.Parse(ab[1]);
            }

            for (long i = 0; i < maxT; i++)
            {
                // 답안
                Console.WriteLine(Combination(a[i], b[i]));
            }
        }

        public static long Combination(long N, long M)
        {
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

