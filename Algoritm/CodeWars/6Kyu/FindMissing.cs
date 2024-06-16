namespace Algoritm.CodeWars._6Kyu
{
    public class FindMissing
    {
        public static int Run(List<int> list)
        {
            if (list == null || list.Count <= 2)
                return 0;

            int difference = list[1] - list[0];

            for (int i = 2; i < list.Count; i++)
            {
                if (list[i] - list[i - 1] != difference)
                    return list[i - 1] + difference;
            }

            return 0;
        }
    }
}
