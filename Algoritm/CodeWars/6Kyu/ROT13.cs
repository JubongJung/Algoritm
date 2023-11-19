using System.Text;
using System.Text.RegularExpressions;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/52223df9e8f98c7aa7000062/train/csharp
    /// </summary>
    public class ROT13
    {
        public static string Rot13(string input)
        {
            char[] bigAlphabetArray = new char[26];
            char[] smallAlphabetArray = new char[26];

            // 알파벳 배열에 알파벳 할당
            for (int i = 0; i < 26; i++)
            {
                bigAlphabetArray[i] = (char)('A' + i); // 대문자 알파벳으로 할당
                smallAlphabetArray[i] = (char)('a' + i); // 소문자 알파벳으로 할당
            }

            StringBuilder sb = new StringBuilder();
            foreach(char c in input) 
            { 
                if(Regex.IsMatch(c.ToString(), "^[A-Z]+"))
                {
                    int index = Array.FindIndex(bigAlphabetArray, x => x.Equals(c));
                    index = index + 13;
                    if(index > 25)
                    {
                        index -= 26;
                    }
                    sb.Append(bigAlphabetArray[index]);
                }
                else if(Regex.IsMatch(c.ToString(), "^[a-z]+"))
                {
                    int index = Array.FindIndex(smallAlphabetArray, x => x.Equals(c));
                    index = index + 13;
                    if (index > 25)
                    {
                        index -= 26;
                    }
                    sb.Append(smallAlphabetArray[index]);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
