using System;
using System.Collections.Generic;
using System.Text;

namespace BaseLib
{
    public class MathConvertor
    {

        public static string DecimalToBinary(int input)
        {
            string binary = Convert.ToString(input, 2);
            return binary;
        }

        public static int BinaryToDecimal(string input)
        {
            int @decimal = Convert.ToInt32(input, 2);
            return @decimal;
        }

        public static string DecimalToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + DecimalToRoman(number - 1000);
            if (number >= 900) return "CM" + DecimalToRoman(number - 900);
            if (number >= 500) return "D" + DecimalToRoman(number - 500);
            if (number >= 400) return "CD" + DecimalToRoman(number - 400);
            if (number >= 100) return "C" + DecimalToRoman(number - 100);
            if (number >= 90) return "XC" + DecimalToRoman(number - 90);
            if (number >= 50) return "L" + DecimalToRoman(number - 50);
            if (number >= 40) return "XL" + DecimalToRoman(number - 40);
            if (number >= 10) return "X" + DecimalToRoman(number - 10);
            if (number >= 9) return "IX" + DecimalToRoman(number - 9);
            if (number >= 5) return "V" + DecimalToRoman(number - 5);
            if (number >= 4) return "IV" + DecimalToRoman(number - 4);
            if (number >= 1) return "I" + DecimalToRoman(number - 1);
            return "";
        }



    }
}
