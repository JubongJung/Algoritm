namespace Algoritm.Programmers
{
    public class Carpet
    {
        public int[] solution(int brown, int yellow)
        {
            int[] answer = new int[] { };

            List<int[]> commonFactors = GetCommonFactor(brown + yellow);
            foreach(var row in commonFactors)
            {
                int border = row[0] * 2 + row[1] * 2 - 4;
                if(border == brown)
                {
                    answer = new int[] { row[1], row[0] };
                    break;
                }
            }

            return answer;
        }

        public List<int[]> GetCommonFactor(int number)
        {
            List<int[]> result = new List<int[]>();
            int count = 1;

            int root = Convert.ToInt32(Math.Sqrt(number));
            Console.WriteLine(root);

            while (true)
            {
                if(number % count == 0)
                {
                    int left = count;
                    int right = number / count;
                    result.Add(new int[] { left, right });
                }

                count++;

                if(count > root)
                {
                    break;
                }
            }
            return result;
        }
    }
}
