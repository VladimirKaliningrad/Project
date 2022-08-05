using System;
using System.Globalization;

/* переменные в с# */


// комментарии однострочный комментарий

namespace Lessons5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "1,9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
             NumberDecimalSeparator = ".",
            };



           double a = Convert.ToDouble(str, numberFormatInfo);

            Console.ReadLine();
        }
    }
}
