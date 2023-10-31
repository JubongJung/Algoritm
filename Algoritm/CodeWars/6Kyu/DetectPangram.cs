using System.Text.RegularExpressions;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/545cedaa9943f7fe7b000048/csharp
    /// </summary>
    public class DetectPangram
    {
        private static int ALPHABET_COUNT = 26;

        public static bool IsPangram(string str)
        {
            List<string> chars = new List<string>();
            foreach(char c in str)
            {
                string letter = c.ToString().ToLower();

                if (Regex.IsMatch(letter, "^[a-z]") && !chars.Contains(letter))
                {
                    chars.Add(letter);
                }
            }

            return chars.Count == ALPHABET_COUNT;
        }
    }
}
