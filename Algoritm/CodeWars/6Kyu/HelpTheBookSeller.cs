namespace Algoritm.CodeWars._6Kyu
{
    public class HelpTheBookSeller
    {
        public static string Run(string[] lstOfArt, string[] lstOf1stLetter)
        {
            if (lstOfArt == null || lstOfArt.Length == 0 || lstOf1stLetter == null || lstOf1stLetter.Length == 0)
                return "";

            Dictionary<string, int> categoryQuantities = new Dictionary<string, int>();

            foreach (string stock in lstOfArt)
            {
                string[] parts = stock.Split(' ');
                string code = parts[0];
                int quantity = int.Parse(parts[1]);

                string category = code.Substring(0, 1);
                if (lstOf1stLetter.Contains(category))
                {
                    if (!categoryQuantities.ContainsKey(category))
                        categoryQuantities[category] = 0;

                    categoryQuantities[category] += quantity;
                }
            }

            List<string> result = new List<string>();
            foreach (string category in lstOf1stLetter)
            {
                int quantity = categoryQuantities.ContainsKey(category) ? categoryQuantities[category] : 0;
                result.Add($"({category} : {quantity})");
            }

            return string.Join(" - ", result);
        }
    }
}
