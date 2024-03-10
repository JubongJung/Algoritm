namespace Algoritm.CodeWars._6Kyu
{
    public class SplitString
    {
        public static string[] Run(string str)
        {
            bool isOdd = str.Length % 2 == 1;
            if (isOdd) 
            {
                str += "_";
            };

            List<string> result = new List<string>();
            for(int i = 0; i < str.Length / 2; i++)
            {
                int index = i * 2;
                result.Add(str[index].ToString() + str[index + 1].ToString());
            }

            return result.ToArray();
        }
    }
}
