namespace Algoritm.CodeWars._6Kyu
{
    public class WeIrDStRiNgCaSe
    {
        public static string Run(string s)
        {
            string result = "";

            int index = 1;

            for(int i = 0; i < s.Length; i++)
            {
                string charString = s[i].ToString();

                if (charString == " ")
                {
                    result += charString;
                    index = 1;
                    continue;
                }

                if(index % 2 == 0)
                {
                    result += charString.ToLower();
                }
                else
                {
                    result += charString.ToUpper();
                }
                index++;
            }

            return result;
        }
    }
}
