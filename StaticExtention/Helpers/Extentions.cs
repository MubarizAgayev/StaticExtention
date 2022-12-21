using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StaticExtention
{
    internal static class Extentions
    {
        public static int GetNum(this int num)
        {
            return num;
        }

        public static bool CheckDigitInString(this string text)
        {
            return Regex.IsMatch(text, @"\d");
        }



        public static int Factorial(this int num)
        {
            int result1 = 1;
            for (int i = 1; i <= num; i++)
            {
                result1 *= i;
            }
            return result1;
        }





        public static double GetPower(this int num1, int pow)
        {
            var result = Math.Pow(num1, pow);
            return result;
        }
    }
}
