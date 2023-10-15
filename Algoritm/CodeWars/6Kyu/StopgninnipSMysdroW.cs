using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.CodeWars._6Kyu
{
    public class StopgninnipSMysdroW
    {
        public string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');

            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 5)
                {
                    StringBuilder sb = new StringBuilder();   

                    for(int j = 0; j < words[i].Length; j++)
                    {
                        int index = words[i].Length - j - 1;
                        sb.Append(words[i][index]);
                    }

                    words[i] = sb.ToString();
                }
            }

            return string.Join(" ", words);
        }
    }
}
