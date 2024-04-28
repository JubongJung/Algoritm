namespace Algoritm.CodeWars._6Kyu
{
    public class TortoiseRace
    {
        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2)
            {
                return new int[] { -1, -1, -1 };
            }

            int seconds = (g * 3600) / (v2 - v1);

            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int remainingSeconds = seconds % 60;

            return new int[] { hours, minutes, remainingSeconds };
        }
    }
}
