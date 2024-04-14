namespace Algoritm.CodeWars._6Kyu
{
    public class WriteNumberInExpandedForm
    {
        public static string ExpandedForm(long num)
        {
            string strNumber = num.ToString();

            List<long> list = new List<long>();
            for(int i = 0; i < strNumber.Length; i++)
            {
                long number = Convert.ToInt64(strNumber[i].ToString());
                if (number > 0)
                {
                    list.Add(number * (long)Math.Pow(10, strNumber.Length - i - 1));
                }
            }

            return string.Join(" + ", list);
        }
    }
}
