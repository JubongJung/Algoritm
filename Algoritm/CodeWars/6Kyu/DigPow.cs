namespace Algoritm.CodeWars._6Kyu
{
    public class DigPow
    {
        public static long Run(int n, int p)
        {
            string strN = n.ToString();
            int powCount = strN.Length;
            double sum = 0;

            for(int i = 0; i < powCount; i++)
            {
                int number = Convert.ToInt32(strN[i].ToString());
                sum += Math.Pow(number, p +i);
            }

            if(sum % n == 0)
            {
                return (int)sum / n;
            };

            return -1;
        }
    }
}
