namespace Algoritm.CodeWars._6Kyu
{
    public class SumofDigits
    {
        /// <summary>
        /// https://www.codewars.com/kata/541c8630095125aba6000c00/train/csharp
        /// </summary>
        public static int DigitalRoot(long n)
        {
            string digit = n.ToString();
            int sum = 0;
            foreach(char c in digit)
            {
                sum += Convert.ToInt32(c.ToString());
            }

            if(sum < 10)
            {
                return sum;
            }
            else
            {
                return DigitalRoot(sum);
            }
        }
    }
}
