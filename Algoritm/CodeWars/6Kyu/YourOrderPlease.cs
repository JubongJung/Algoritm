using System.Text.RegularExpressions;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/55c45be3b2079eccff00010f/csharp
    /// </summary>
    public class YourOrderPlease
    {
        public static string Order(string words)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            string[] arr = words.Split(' ');
            foreach (string word in arr)
            {
                int key = 0;

                foreach(char c in word)
                {
                    var reg = new Regex("^[0-9]+$");
                    if (reg.IsMatch(c.ToString()))
                    {
                        key = Convert.ToInt32(c.ToString());
                    };
                }

                dic.Add(key, word);
            }

            return string.Join(' ', dic.OrderBy(x => x.Key).Select(x=>x.Value));
        }
    }
}
