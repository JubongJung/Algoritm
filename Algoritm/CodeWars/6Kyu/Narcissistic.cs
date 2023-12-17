namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/5287e858c6b5a9678200083c/csharp
    /// </summary>
    public class Narcissistic
    {
        public static bool Narcissistic_(int value)
        {
            int result = 0;
            var digit = value.ToString().Length;
            foreach (char s in value.ToString())
            {
                result += (int)Math.Pow(Convert.ToInt32(s.ToString()), digit);
            }
            return value == result;
        }
    }
}
