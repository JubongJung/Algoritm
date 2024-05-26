using System.Text;

namespace Algoritm.CodeWars._6Kyu
{
    internal class ToCamelCase
    {
        public static string Run(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            string[] words = str.Split(' ');
            StringBuilder result = new StringBuilder();
            for (int i = 0; i<words.Length; i++)
            {
                var arrWord = words[i].ToCharArray();
                StringBuilder sb = new StringBuilder();
                for(int j = 0; j < arrWord.Length; j++)
                {
                    if(j == 0)
                    {
                        sb.Append(arrWord[j].ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(arrWord[j].ToString().ToLower());
                    }
                }
                result.Append(sb.ToString());
            }

            return result.ToString();
        }
    }
}
