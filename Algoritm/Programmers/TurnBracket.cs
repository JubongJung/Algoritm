namespace Algoritm.Programmers
{
    /// <summary>
    /// https://school.programmers.co.kr/learn/courses/30/lessons/76502
    /// </summary>
    public class TurnBracket
    {
        public int solution(string s)
        {
            int answer = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (IsTrueBracket(s))
                {
                    answer++;
                };

                s = s.Substring(s.Length - 1, 1) + s.Substring(0, s.Length - 1);
                Console.WriteLine($"s: {s}");
            }

            return answer;
        }

        /// <summary>
        /// 괄호 별로 오른쪽이 먼저 나올 경우 false
        /// </summary>
        public bool IsTrueBracket(string s)
        {
            Stack<char> stack = new Stack<char>();

            bool result = true;

            foreach (char c in s)
            {
                char peek;

                switch(c)
                {
                    case '(':
                        stack.Push(c);
                        break;
                    case ')':
                        if(stack.TryPeek(out peek) && peek == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            result = false;
                        }
                        break;
                    case '{':
                        stack.Push(c);
                        break;
                    case '}':
                        if (stack.TryPeek(out peek) && peek == '{')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            result = false;
                        }
                        break;
                    case '[':
                        stack.Push(c);
                        break;
                    case ']':
                        if (stack.TryPeek(out peek) && peek == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            result = false;
                        }
                        break;
                }

                if (result == false) break;
            }

            return result && stack.Count == 0;
        }
    }
}
