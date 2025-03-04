using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    struct DecimalNumber
    {
        public decimal num;

        public decimal InputNum()
        {
            Console.Write("Enter a decimal num: ");
            while (!decimal.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Invalid input. Enter a decimal num: ");
            }
            return num;
        }

        public static string ConvertToSystem(int num, int baseNum)
        {
            if (num == 0) return "0";

            string result = "";

            while (num > 0)
            {
                result = (num % baseNum) + result;
                num /= baseNum;
            }
            return result;
        }

        private static string ConvertToHexadecimal(int num)
        {
            if (num == 0) return "0";
            string chars = "0123456789ABCDEF";
            string result = "";
            while (num > 0)
            {
                result = chars[num % 16] + result;
                num /= 16;
            }
            return result;
        }

        public string ToBinary()
        {
            return ConvertToSystem((int)num, 2);
        }

        public string ToOctal()
        {
            return ConvertToSystem((int)num, 8);
        }

        public string ToHexadecimal()
        {
            return ConvertToHexadecimal((int)num);
        }
    }
}

