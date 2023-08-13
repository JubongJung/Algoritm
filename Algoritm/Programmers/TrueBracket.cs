namespace Algoritm.Programmers
{
    public class TrueBracket
    {
        public bool solution(string s)
        {
            char leftBracket = '(';
            char rightBracket = ')';

            Stack<char> stack = new Stack<char>();

            if (s[0] == rightBracket) { return false; }
            if(s.Length % 2 != 0) { return false; }

            for(int i  = 0; i < s.Length; i++)
            {
                if (s[i] == leftBracket)
                {

                    stack.Push(s[i]);
                }
                else
                {
                    if(!stack.TryPop(out char _))
                    {
                        return false;
                    };
                }
                
            }

            if(stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
