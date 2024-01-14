namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/585d7d5adb20cf33cb000235/csharp
    /// </summary>
    public class GetUnique
    {
        public static int GetAnswer(IEnumerable<int> numbers)
        {
            List<int> numberList = numbers.ToList();
            List<int> check = new List<int>();
            
            for(int i = 0; i < 3; i++)
            {
                check.Add(numberList[i]);
            }

            int first = numberList.First();

            if (numberList.Where(x=>x.Equals(first)).Count() == 3)
            {
                foreach(var number in numbers)
                {
                    if (!number.Equals(first))
                    {
                        return number;
                    }
                }
            }
            else if (numberList.Where(x => x.Equals(first)).Count() == 1)
            {
                return first;
            }
            else
            {
                return numberList.Where(x => !x.Equals(first)).First();
            }

            return 0;
        }
    }
}
