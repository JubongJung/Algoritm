namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/583203e6eb35d7980400002a/csharp
    /// </summary>
    public class CountTheSmileyFaces
    {
        private static readonly string[] Eyes = {":",";" };
        private static readonly string[] Nose = {"-", "~" };
        private static readonly string[] Mouth = { ")","D" };


        public static int CountSmileys(string[] smileys)
        {
            int result = 0;

            foreach(string s in smileys)
            {
                if(s.Length == 3)
                {
                    if (!Eyes.Contains(s[0].ToString()))
                    {
                        continue;
                    }
                    if (!Nose.Contains(s[1].ToString()))
                    {
                        continue;
                    }
                    if (!Mouth.Contains(s[2].ToString()))
                    {
                        continue;
                    }
                    result++;
                }
                else if(s.Length == 2)
                {
                    if (!Eyes.Contains(s[0].ToString()))
                    {
                        continue;
                    }
                    if (!Mouth.Contains(s[1].ToString()))
                    {
                        continue;
                    }
                    result++;
                }
            }

            return result;
        }
    }
}
