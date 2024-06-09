namespace Algoritm.CodeWars._6Kyu
{
    public class ReverseOrRotate
    {
        public static string Run(string strng, int sz)
        {
            if (sz <= 0 || string.IsNullOrEmpty(strng))
                return "";

            int chunkCount = strng.Length / sz;
            string[] chunks = new string[chunkCount];

            for (int i = 0; i < chunkCount; i++)
            {
                string chunk = strng.Substring(i * sz, sz);
                int chunkSum = chunk.Sum(c => c - '0');

                if (chunkSum % 2 == 0)
                    chunks[i] = new string(chunk.Reverse().ToArray());
                else
                    chunks[i] = chunk.Substring(1) + chunk[0];
            }

            return string.Join("", chunks);
        }
    }
}
