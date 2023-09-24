using System.Text;

namespace Algoritm.CodeWars._6Kyu
{
    public class ConvertStringToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            char[] chars = str.ToCharArray();
            StringBuilder sb = new StringBuilder();

            int i = 0;
            while(i < chars.Length)
            {
                if (chars[i] == '_' || chars[i] == '-')
                {
                    sb.Append(chars[i + 1].ToString().ToUpper());
                    i += 2;
                }
                else
                {
                    sb.Append(chars[i]);
                    i++;
                }
            }
            

            return sb.ToString();
        }
    }
}
