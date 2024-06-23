using System.Text;

namespace Algoritm.CodeWars._6Kyu
{
    public class CleanString
    {
        public static string Run(string s)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in s)
            {
                if (c == '#')
                {
                    if (result.Length > 0)
                    {
                        result.Length--; 
                    }
                }
                else
                {
                    result.Append(c); 
                }
            }

            return result.ToString();
        }
    }
}
