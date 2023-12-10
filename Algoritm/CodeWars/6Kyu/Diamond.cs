using System.Text;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/5503013e34137eeeaa001648
    /// </summary>
    public class Diamond
    {
        public static string print(int n)
        {
            if(n%2 == 0 || n < 0)
            {
                return null;
            }

            int times = n / 2 + 1;

            StringBuilder sb = new StringBuilder();

            for(int i = 1; i <= times; i++)
            {
                int blankCount = times - i;
                int starCount = i * 2 - 1;
                for(int j = 0; j < blankCount; j++)
                {
                    sb.Append(" ");
                }
                for(int j = 0; j < starCount; j++)
                {
                    sb.Append("*");
                }
                sb.Append('\n');
            }

            for (int i = times - 1; i > 0; i--)
            {
                int blankCount = times - i;
                int starCount = i * 2 - 1;
                for (int j = 0; j < blankCount; j++)
                {
                    sb.Append(" ");
                }
                for (int j = 0; j < starCount; j++)
                {
                    sb.Append("*");
                }
                sb.Append('\n');
            }

            return sb.ToString();
        }
    }
}
