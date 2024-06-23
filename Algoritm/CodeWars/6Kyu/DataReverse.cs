namespace Algoritm.CodeWars._6Kyu
{
    public class DataReverse
    {
        public static int[] Run(int[] data)
        {
            int segmentLength = 8;
            int totalLength = data.Length;

            string bitString = string.Join("", data);

            List<string> segments = new List<string>();
            for (int i = 0; i < bitString.Length; i += segmentLength)
            {
                segments.Add(bitString.Substring(i, segmentLength));
            }

            segments.Reverse();

            string reversedBitString = string.Join("", segments);

            int[] reversedBits = reversedBitString.Select(c => c - '0').ToArray();

            return reversedBits;
        }

    }
}
