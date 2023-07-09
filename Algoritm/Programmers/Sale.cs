using System.Text;

namespace Algoritm.Programmers
{
    /// <summary>
    /// https://school.programmers.co.kr/learn/courses/30/lessons/131127?language=csharp
    /// </summary>
    public class Sale
    {
        public int GetResult(string[] want, int[] number, string[] discount)
        {
            var shoppingList = MakeDictionary(want, number);

            int result = 0;

            for (int i = 0; i < discount.Length - 10 + 1; i++)
            {
                Console.WriteLine(i);

                var tmpShoppingList = new Dictionary<string, int>(shoppingList);
                StringBuilder sbInitial = new StringBuilder();
                foreach (var item in tmpShoppingList)
                {
                    sbInitial.Append(item.ToString());
                }
                Console.WriteLine(sbInitial);

                for (int j = i; j < i + 10; j++)
                {
                    if (tmpShoppingList.ContainsKey(discount[j]))
                    {
                        tmpShoppingList[discount[j]] -= 1;
                        if (tmpShoppingList[discount[j]] == 0) tmpShoppingList.Remove(discount[j]);
                    }
                    Console.WriteLine($"i: {i}, j: {j}");
                }

                StringBuilder sb = new StringBuilder();
                foreach(var item in tmpShoppingList)
                {
                    sb.Append(item.ToString());
                }
                Console.WriteLine(sb);
                

                if (tmpShoppingList.Count == 0) result++;
            }

            return result;
        }

        public Dictionary<string, int> MakeDictionary(string[] want, int[] number)
        {
            Dictionary<string, int> wants = new Dictionary<string, int>();
            for (int i = 0; i < want.Length; i++)
            {
                wants.Add(want[i], number[i]);
            }

            return wants;
        }
    }
}
