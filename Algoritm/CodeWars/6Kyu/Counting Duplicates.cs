namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/solutions/csharp
    /// </summary>
    public class Counting_Duplicates
    {
        public static int DuplicateCount(string str)
        {
            int result = 0;
            str = str.ToLower();

            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach(char c in str)
            {
                if (dic.ContainsKey(c.ToString()))
                {
                    dic[c.ToString()]++;
                }
                else
                {
                    dic.Add(c.ToString(), 1);
                }
            }

            foreach(var row in dic)
            {
                if(row.Value > 1)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
