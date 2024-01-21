using System.Text.RegularExpressions;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp
    /// </summary>
    public class ReplaceWithAlphabetPosition
    {
        public static string Run(string text)
        {
            List<int> list = new List<int>();

            foreach(var item in text)
            {
                string letter = item.ToString().ToUpper();
                if(Regex.IsMatch(letter, "^[A-Z]*$"))
                {
                    int value = Convert.ToChar(letter) - 64;
                    if(value <= 0)
                    {
                        value += 64;
                    }
                    list.Add(value);
                }
            }

            string result = string.Join(' ', list);
            Console.Write(result);
            return result;
        }
    }
}
