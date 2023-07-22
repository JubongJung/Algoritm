namespace Algoritm.Programmers
{
    public class MaxMin
    {
        public string solution(string s)
        {
            string answer = "";

            Stack<int> max = new Stack<int>();
            Stack<int> min = new Stack<int>();

            foreach (string number in s.Split(' '))
            {
                int num = int.Parse(number);
                

                if(max.TryPeek(out int maxNum))
                {
                    if(maxNum < num)
                    {
                        max.Push(num);
                    }
                }
                else
                {
                    max.Push(num);
                }

                if(min.TryPeek(out int minNum))
                {
                    if(minNum > num)
                    {
                        min.Push(num);
                    }
                }
                else
                {
                    min.Push(num);
                }
            };

            answer += min.Peek().ToString();
            answer += " ";
            answer += max.Peek().ToString();


            return answer;
        }
    }
}
