using System.Globalization;

namespace Algoritm.CodeWars._6Kyu
{
    public class TitleCase
    {
        public static string ConvertToTitleCase(string input, string minorWords = "")
        {
            string[] words = input.Split(' ');

            words[0] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[0].ToLower());

            for (int i = 1; i < words.Length; i++)
            {
                string word = words[i].ToLower();
                if (!string.IsNullOrEmpty(minorWords) && minorWords.ToLower().Split(' ').Contains(word))
                    words[i] = word;
                else
                    words[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word);
            }

            return string.Join(" ", words);
        }
    }
}
