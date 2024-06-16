namespace Algoritm.CodeWars._6Kyu
{
    public class EncryptThis
    {
        public static string Run(string input)
        {
            string[] words = input.Split(' ');
            string[] encryptedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (string.IsNullOrEmpty(word))
                {
                    encryptedWords[i] = word;
                    continue;
                }

                char firstChar = word[0];
                string asciiFirstChar = ((int)firstChar).ToString();

                if (word.Length == 1)
                {
                    encryptedWords[i] = asciiFirstChar;
                }
                else if (word.Length == 2)
                {
                    encryptedWords[i] = asciiFirstChar + word[1];
                }
                else
                {
                    char secondChar = word[1];
                    char lastChar = word[word.Length - 1];
                    string middle = word.Substring(2, word.Length - 3);

                    encryptedWords[i] = asciiFirstChar + lastChar + middle + secondChar;
                }
            }

            return string.Join(" ", encryptedWords);
        }
    }
}
