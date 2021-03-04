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


    }
}
