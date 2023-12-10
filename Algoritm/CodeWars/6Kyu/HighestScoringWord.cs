namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://codewars.com/kata/57eb8fcdf670e99d9b000272
    /// </summary>
    public class HighestScoringWord
    {
        public static string High(string s)
        {
            string[] word = s.Split(' ');
            Dictionary<string, int> words = new Dictionary<string, int>();
            
            foreach(string key in word)
            {
                foreach(char c in key)
                {
                    int value = (byte)c - 96;

                    if (words.ContainsKey(key))
                    {
                        words[key] += value;
                    }
                    else
                    {
                        words.Add(key, value);
                    }
                }
            }

            return words.OrderByDescending(x => x.Value).First().Key;
        }
    }
}
