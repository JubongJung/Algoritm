namespace Algoritm.CodeWars._6Kyu
{
    public class DuplicateEncoder
    {
        public static string Run(string word) 
        {
            string lowerCaseString = word.ToLower();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in lowerCaseString)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            string newString = "";
            foreach (char c in lowerCaseString)
            {
                if (charCount[c] == 1)
                {
                    newString += "(";
                }
                else
                {
                    newString += ")";
                }
            }

            return newString;
        }
    }
}
