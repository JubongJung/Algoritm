namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/54da539698b8a2ad76000228/csharp
    /// </summary>
    public class TakeTenMinutesWalk
    {
        public static bool Run(string[] walk)
        {
            int ns = 0;
            int we = 0;

            foreach(string s in walk)
            {
                switch(s)
                {
                    case "s": 
                        ns++;
                         break;

                    case "n":
                        ns--;
                        break;

                    case "w":
                        we++;
                        break;

                    case "e":
                        we--;
                        break;
                }
            }

            return ns == 0 && we == 0 && walk.Length == 10;

        }
    }
}
