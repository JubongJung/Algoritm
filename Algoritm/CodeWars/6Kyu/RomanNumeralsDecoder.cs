﻿namespace Algoritm.CodeWars._6Kyu
{
    public class RomanNumeralsDecoder
    {
        public static int Solution(string roman)
        {
            Dictionary<char, int> RomanToDecimal = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;
            int prevValue = 0;

            for (int i = roman.Length - 1; i >= 0; i--)
            {
                char currentChar = roman[i];
                int currentValue = RomanToDecimal[currentChar];

                if (currentValue < prevValue)
                    result -= currentValue;
                else
                    result += currentValue;

                prevValue = currentValue;
            }

            return result;
        }
    }
}
