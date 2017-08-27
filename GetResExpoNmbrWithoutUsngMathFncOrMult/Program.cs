using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetResExpoNmbrWithoutUsngMathFncOrMult
{
    class Program
    {
        private static string CalculateExponentialNumber(int baseNumber, int exponent)
        {
            var res = 0;
            for (int i = 0; i < exponent; i++)
            {
                res = res + getExponential(baseNumber);
            }
            return res.ToString();
        }

        static int getExponential(int num)
        {
            var cont = 0;
            for (int i = 0; i < num; i++)
            {
                cont = cont + num;
            }
            return cont;
        }

        static void Main(string[] args)
        {
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            int exponent = Convert.ToInt32(Console.ReadLine());
            string result = string.Empty;

            var theResultIsEqualTo1 = baseNumber == 0 ? true : false;

            if (theResultIsEqualTo1)
                result = "1";
            else
                result = CalculateExponentialNumber(baseNumber, exponent);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
