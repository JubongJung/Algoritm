namespace Algoritm.Programmers
{
    public class HIndex
    {
        public int solution(int[] citations)
        {
            int answer = 0;

            int[] orderedC = citations.OrderByDescending(x => x).ToArray();

            for(int number = citations.Count(); number > 0; number--)
            {
                int count = 0;

                foreach (int citation in orderedC)
                {
                    if (number <= citation)
                    {
                        count++;
                        //break;
                    }
                }

                if (count >= number)
                {
                    answer = number; break;
                }
            }
            
            return answer;
        }
    }
}
