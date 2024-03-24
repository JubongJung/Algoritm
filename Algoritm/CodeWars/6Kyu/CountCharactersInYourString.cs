namespace Algoritm.CodeWars._6Kyu
{
    public class CountCharactersInYourString
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach(char c in str)
            {
                if (result.ContainsKey(c))
                {
                    result[c] += 1;
                }
                else
                {
                    result.Add(c, 1);
                }
            }
            foreach (var c in result)
            {

                Console.WriteLine($"key: {c.Key}, value: {c.Value}");
            }

            return result;
        }
    }
}
