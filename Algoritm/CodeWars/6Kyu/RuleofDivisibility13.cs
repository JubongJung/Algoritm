namespace Algoritm.CodeWars._6Kyu
{
    public class RuleofDivisibility13
    {
        public static long Run(long n)
        {
            int[] pattern = { 1, 10, 9, 12, 3, 4 };
            long sum = 0;

            while (true)
            {
                long currentSum = n.ToString()
                                    .Reverse()
                                    .Select((digit, index) => (digit - '0') * pattern[index % pattern.Length])
                                    .Sum();

                if (currentSum == sum)
                    break;

                sum = currentSum;
                n = sum;
            }

            return sum;
        }
    }
}
