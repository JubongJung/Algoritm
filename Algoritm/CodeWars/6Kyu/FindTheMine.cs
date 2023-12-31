namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/528d9adf0e03778b9e00067e/csharp
    /// </summary>
    public class FindTheMine
    {
        public static Tuple<int, int> MineLocation(int[,] field)
        {
            int size = (int)Math.Sqrt(field.Length);
            int count = 0;


            foreach (var item in field) 
            {
                if (item.Equals(1))
                {
                    return Tuple.Create(count / size, count % size);
                }
                count++;
            }

            return Tuple.Create(0, 0);
        }
    }
}
