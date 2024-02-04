namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/59c633e7dcc4053512000073/csharp
    /// </summary>
    public class ConsonantValue
    {
        public static int Solve(string s)
        {
            char[] aeiou = { 'a', 'e', 'i', 'o', 'u' };
            List<string> words = new List<string>();
            string temp = "";
            foreach (char c in s)
            {
                if (aeiou.Contains(c))
                {
                    words.Add(temp);
                    temp = "";
                }
                else
                {
                    temp += c;
                }
            }

            List<int> sums = new List<int>();
            foreach (var word in words)
            {
                int sum = 0;

                foreach (char c in word)
                {
                    sum += c - 96;
                }
                sums.Add(sum);
            }

            return sums.OrderByDescending(a => a).First();
        }
    }
}
