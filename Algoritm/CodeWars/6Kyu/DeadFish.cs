namespace Algoritm.CodeWars._6Kyu
{
    public class DeadFish
    {
        public static int[] Parse(string data)
        {
            int value = 0;
            List<int> result = new List<int>();

            foreach (char command in data)
            {
                switch (command)
                {
                    case 'i':
                        value++;
                        break;
                    case 'd':
                        value--;
                        break;
                    case 's':
                        value *= value;
                        break;
                    case 'o':
                        result.Add(value);
                        break;
                    default:
                        // Ignore invalid characters
                        break;
                }
            }

            return result.ToArray();
        }
    }
}
