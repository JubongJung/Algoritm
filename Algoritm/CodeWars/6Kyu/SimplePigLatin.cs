using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/csharp
    /// </summary>
    public class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            string[] strings = str.Split(' ');
            for(int i =0; i < strings.Length; i++)
            {
                if (Regex.IsMatch(strings[i], "^[a-zA-Z]+"))
                {
                    string changed = strings[i].Substring(1, strings[i].Length - 1) + strings[i][0] + "ay";
                    strings[i] = changed;
                }
            }
            
            return string.Join(' ', strings);
        }
    }
}
