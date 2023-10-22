namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
    /// </summary>
    public class BreakCamelCase
    {
        public string _BreakCamelCase(string str)
        {
            List<string> words = new List<string>();

            int startIndex = 0;

            for(int i=0; i<str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    words.Add(str.Substring(startIndex, i - startIndex));
                    startIndex = i;
                };
            }

            words.Add(str.Substring(startIndex, str.Length - startIndex));

            return string.Join(' ', words);
        }
    }
}
