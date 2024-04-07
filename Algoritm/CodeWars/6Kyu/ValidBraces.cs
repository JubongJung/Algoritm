using System.Security.Cryptography.X509Certificates;

namespace Algoritm.CodeWars._6Kyu
{
    public class ValidBraces
    {
        public static bool validBraces(String braces)
        {
            char leftSmall = '(';
            char rightSmall = ')';
            char leftMedium = '{';
            char rightMedium = '}';
            char leftLarge = '[';
            char rightLarge = ']';
            string left = "({[";
            string right = ")}]";
            
            Stack<char> stack = new Stack<char>();
            foreach(char c in braces)
            {
                char top;

                if(stack.Any())
                {
                    // 여는경우
                    if (left.Contains(c))
                    {
                        stack.Push(c);
                    }
                    // 닫는경우
                    else
                    {
                        top = stack.Peek();

                        if (top.Equals(leftSmall) && c.Equals(rightSmall))
                        {
                            stack.Pop();
                            continue;
                        }
                        if (top.Equals(leftMedium) && c.Equals(rightMedium))
                        {
                            stack.Pop();
                            continue;
                        }
                        if (top.Equals(leftLarge) && c.Equals(rightLarge))
                        {
                            stack.Pop();
                            continue;
                        }

                        return false;
                    }
                }
                else
                {
                    if (right.Contains(c))
                    {
                        return false;
                    }
                    else 
                    {
                        stack.Push(c);
                        continue;
                    }
                }
            }

            return stack.Any() == false;
        }
    }
}
