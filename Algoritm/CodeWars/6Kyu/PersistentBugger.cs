namespace Algoritm.CodeWars._6Kyu
{
    public class PersistentBugger
    {
        public static int Run(long n)
        {
            char[] ints = n.ToString().ToCharArray();

            int result = 0;

            if (ints.Length == 1) return 0;

            int tmp = 1;

            foreach (char c in ints)
            {
                tmp *= Convert.ToInt32(c.ToString());
                
            }
            result++;

            while (tmp.ToString().Length > 1)
            {
                ints = tmp.ToString().ToCharArray();
                tmp = 1;
                foreach (char c in ints)
                {
                    tmp *= Convert.ToInt32(c.ToString());
                }
                result++;
            }

            return result;
        }
    }
}
