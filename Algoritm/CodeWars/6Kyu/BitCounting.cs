using System.Text;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/526571aae218b8ee490006f4/csharp
    /// </summary>
    public class BitCounting
    {
        public static int CountBits(int n)
        {
            string bit = "";
            if(n == 0) bit = "0";
            while(DivdeTwo(ref n, ref bit) > 1){};

            if(n > 0)
            {
                bit = $"{n}{bit}";
            }

            int result = 0;

            foreach(char c in bit)
            {
                if(c.ToString() == "1") result++;
            }

            return result;
        }

        public static int DivdeTwo(ref int n, ref string bit)
        {
            var remain = n % 2;
            n = n / 2;

            bit = $"{remain}{bit}";

            return n;
        }
    }
}
