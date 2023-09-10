namespace Algoritm.Programmers
{
    public class MultiplicationProcession
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int arr1Row = arr1.GetLength(0);
            int arr1Col = arr1.GetLength(1);
            int arr2Col = arr2.GetLength(1);

            int[,] answer = new int[arr1Row, arr2Col];

            for (int i = 0; i < arr1Row; i++)
            {
                for (int j = 0; j < arr2Col; j++)
                {
                    for (int k = 0; k < arr1Col; k++)
                    {
                        answer[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }

            return answer;
        }

    }
}
