namespace Algoritm.CodeWars._6Kyu
{
    public class ValidateCreditCardNumber
    {
        public static bool Run(string n)
        {
            n = n.Replace(" ", "");

            int sum = 0;
            bool doubleDigit = false;

            for (int i = n.Length - 1; i >= 0; i--)
            {
                int digit = n[i] - '0';

                if (doubleDigit)
                {
                    digit *= 2;
                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }

                sum += digit;
                doubleDigit = !doubleDigit;
            }

            return sum % 10 == 0;
        }
    }
}
