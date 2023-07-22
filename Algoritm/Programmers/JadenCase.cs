using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Text.RegularExpressions;

namespace Algoritm.Programmers
{
    public class JadenCase
    {
        public string solution(string s)
        {
            string answer = "";

            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    Regex regex = new Regex("^[0-9]*$");
                    bool isNumber = regex.IsMatch(word[i].ToString());
                    if (isNumber)
                        answer += word[i].ToString();
                    else
                        answer += i==0 ? word[i].ToString().ToUpper() : word[i].ToString().ToLower();
                }


                answer += " ";
            }

            

            return answer.Remove(answer.Length - 1, 1);
        }
    }
}
