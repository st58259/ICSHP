using System;

namespace BaseLib
{
    public class Reading
    {
        //Takes string returns int 
        public static int ReadInt(string ins)
        {
            Console.Write(ins + " : ");
            string s = Console.ReadLine();

            if (int.TryParse(s, out int res))
            {
                return res;
            }

            throw new ArgumentException();
        }

        //Takes string returns double 
        public static double ReadDouble(string ins)
        {
            Console.Write(ins + " : ");
            string s = Console.ReadLine();

            if (double.TryParse(s, out double res))
            {
                return res;
            }

            throw new ArgumentException();
        }

        //Takes string returns char 
        public static char ReadChar(string ins)
        {
            Console.Write(ins + " : ");
            string s = Console.ReadLine();

            if (char.TryParse(s, out char res))
            {
                return res;
            }

            throw new ArgumentException();
        }

        //Takes string returns string
        public static string ReadString(string ins)
        {
            Console.Write(ins + " : ");
            string s = Console.ReadLine();
            return s;
        }
    }
}
