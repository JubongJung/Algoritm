namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/5839edaa6754d6fec10000a2/csharp
    /// </summary>
    public class FindMissingLetter
    {
        public static char Run(char[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i-0] + 1 != array[i])
                {
                    return Convert.ToChar(array[i-1] + 1);
                }
            }

            return ' ';
        }
    }
}
