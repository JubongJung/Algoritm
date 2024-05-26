namespace Algoritm.CodeWars._6Kyu
{
    public class RectangleIntoSquares
    {
        public static List<int> Run(int lng, int wdth)
        {
            if (lng == wdth)
            {
                return null;
            }

            List<int> result = new List<int>();

            while (lng != wdth)
            {
                if (lng > wdth)
                {
                    result.Add(wdth);
                    lng -= wdth;
                }
                else
                {
                    result.Add(lng);
                    wdth -= lng;
                }
            }

            result.Add(lng);

            return result;
        }
    }
}
