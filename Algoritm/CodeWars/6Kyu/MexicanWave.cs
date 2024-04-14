using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.CodeWars._6Kyu
{
    public class MexicanWave
    {
        public static List<string> wave(string str)
        {
            str = str.ToLower();
            List<string> list = new List<string>();
            for(int i  = 0; i < str.Length; i++)
            {
                char[] strArray = str.ToArray();
                if (strArray[i].ToString() == " ")
                {
                    continue;
                }
                strArray[i] = strArray[i].ToString().ToUpper().ToCharArray()[0];

                list.Add(string.Join("", strArray));
            }

            return list;
        }
    }
}
