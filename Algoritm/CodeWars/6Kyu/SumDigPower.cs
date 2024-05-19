namespace Algoritm.CodeWars._6Kyu
{
    public class SumDigPower
    {
        public static long[] SumDigPow(long a, long b)
        {
            List<long> result = new List<long>();
            for(long i = a; i <= b; i++)
            {
                long number = i;
                string strNumber = number.ToString();
                long tempNumber = 0;
                int pow = 1;
                foreach(char str in strNumber)
                {
                    tempNumber += (long)Math.Pow(Convert.ToInt32(str.ToString()), pow);
                    pow++;
                }
                if(tempNumber == number)
                {
                    result.Add(tempNumber);
                }
            }

            return result.ToArray();
        }
    }
}
