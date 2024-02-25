using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.CodeWars._6Kyu
{
    public class MorseCodeDecoder
    {
        public static Dictionary<char, String> morse = new Dictionary<char, string>()
    {
        {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."},
        {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
        {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."},
        {'S', "..."}, {'T', "-"}, {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
        {'Y', "-.--"}, {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"},
        {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."},
        {'8', "---.."}, {'9', "----."},
        {'.', ".-.-.-"}, {',', "--..--"}, {'?', "..--.."}, {'!', "-.-.--"}, {'\'', ".----."},
        {'\"', ".-..-."}, {'/', "-..-."}, {'(', "-.--."}, {')', "-.--.-"}, {'&', ".-..."},
        {':', "---..."}, {';', "-.-.-."}, {'=', "-...-"}, {'+', ".-.-."}, {'-', "-....-"},
        {'_', "..--.-"}, {'$', "...-..-"}, {'@', ".--.-."}
    };

        public static string Decode(string morseCode)
        {
            string[] words = morseCode.Split("   ");
            StringBuilder sb = new StringBuilder();
            foreach(string word in words)
            {
                string[] morseWord = word.Split(" ");

                foreach(string c in morseWord)
                {
                    if(morse.Where(x => x.Value.Equals(c)).Any())
                    {
                        char code = morse.Where(x => x.Value.Equals(c)).First().Key;
                        sb.Append(code.ToString());
                    }
                    else if(c.Equals("...---..."))
                    {
                        sb.Append("SOS");
                    }
                }
                sb.Append(" ");
            }
            return sb.ToString().TrimEnd().TrimStart();
        }
    }
}
