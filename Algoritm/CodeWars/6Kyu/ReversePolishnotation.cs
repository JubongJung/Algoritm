namespace Algoritm.CodeWars._6Kyu
{
    public class ReversePolishnotation
    {
        public static double Run(string expr)
        {
            Stack<double> stack = new Stack<double>();
            
            foreach (string element in expr.Split(" "))
            {
                if (double.TryParse(element, out double stackElement))
                {
                    stack.Push(stackElement);
                }
                else
                {
                    if(stack.Count < 2)
                    {
                        return 0;
                    }

                    double num2 = stack.Pop();
                    double num1 = stack.Pop();

                    switch (element)
                    {
                        case "+":
                            stack.Push(num1 + num2);
                            break;
                        case "-":
                            stack.Push(num1 - num2);
                            break;
                        case "*":
                            stack.Push(num1 * num2);
                            break;
                        case "/":
                            stack.Push(num1 / num2);
                            break;
                        default:
                            break;
                    };
                }
            }

            return stack.Pop();
        }
    }
}
