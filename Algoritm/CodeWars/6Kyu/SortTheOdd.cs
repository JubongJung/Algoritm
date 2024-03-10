namespace Algoritm.CodeWars._6Kyu
{
    public class SortTheOdd
    {
        public static int[] Run(int[] array)
        {
            List<int> oddValueList = new List<int>();
            List<int> oddIndexList = new List<int>();
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    oddIndexList.Add(i);
                    oddValueList.Add(array[i]);
                }
            }

            oddValueList = oddValueList.OrderBy(x => x).ToList();

            for(int i = 0; i < oddIndexList.Count; i++)            
            {
                array[oddIndexList[i]] = oddValueList[i];
            }

            return array;
        }
    }
}
