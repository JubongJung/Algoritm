using System.Runtime.InteropServices;

namespace Algoritm.CodeWars._6Kyu
{
    public class BuildTower
    {
        public static string[] Run(int nFloors) 
        {
            List<string> list = new List<string>();
            string star = "*";
            string blank = " ";


            for(int starCount = 0; starCount < nFloors; starCount++)
            {
                int blankCount = nFloors - starCount;
                string left = "";
                string right = "";
                Console.WriteLine($"floor: {nFloors}, blackCount: {blankCount}, starCount: {starCount}");
                for (int i = 1; i < blankCount; i++)
                {
                    left += blank;
                    right += blank;
                }
                for(int j = 0; j < starCount; j++)
                {
                    left = left + star;
                    right = star + right;
                }

                list.Add(left + star + right);
            }
            return list.ToArray();
        }
    }
}
