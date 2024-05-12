namespace Algoritm.CodeWars._6Kyu
{
    public class BouncingBalls
    {
        public static int Run(double h, double bounce, double window)
        {
            if (h < 0 || bounce >= 1 || bounce <= 0 || window >= h)
            {
                return -1;
            }

            int bounceCount = 0;

            while (h > window)
            {
                bounceCount++;
                h = h * bounce;
                if (h > window)
                {
                    bounceCount++;
                }
            }
            return bounceCount;
        }
    }
}
