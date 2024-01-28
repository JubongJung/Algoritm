namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/5ce399e0047a45001c853c2b/csharp
    /// </summary>
    public class SumsOfParts
    {
        public static int[] PartsSums(int[] ls)
        {
            int sum = ls.Sum(x=> x);

            List<int> ints = new List<int>();
            ints.Add(sum);
            foreach(var row in ls)
            {
                sum -= row;
                ints.Add(sum);
            }

            return ints.ToArray();
        }
    }
}
