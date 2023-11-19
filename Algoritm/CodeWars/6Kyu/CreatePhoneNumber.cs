using System.Text;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp
    /// </summary>
    public class CreatePhoneNumber
    {
        public static string Create(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();

            foreach(int number in numbers)
            {
                sb.Append(number);
            }

            string phoneNumber = sb.ToString();

            return $"({phoneNumber.Substring(0, 3)}) {phoneNumber.Substring(3, 3)}-{phoneNumber.Substring(6, 4)}";
        }
    }
}
