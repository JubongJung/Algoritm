namespace Algoritm.CodeWars
{
    public class MultiplesOf3or5
    {
        public static int Solution(int value)
        {
            int result = 0;

            for(int i = 3; i < value; i++)
            {
                if (i % 3 == 0) {
                    result += i;
                }
                else if(i%5 ==0)
                {
                    result += i;
                };
            }

            return result;
        }
    }
}
