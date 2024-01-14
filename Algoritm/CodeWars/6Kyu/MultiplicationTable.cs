namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/534d2f5b5371ecf8d2000a08/solutions/csharp
    /// </summary>
    public class MultiplicationTable
    {
        public static int[,] GetAnswer(int size)
        {
            int[,] answer = new int[size, size];
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    answer[i, j] = (i+1) * (j+1);
                }
            }

            return answer;
        }
    }
}
