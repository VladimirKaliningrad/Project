using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str;

            double a, b;

            Console.WriteLine("Введите число 1");

            str = Console.ReadLine();


            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",




            };

            a = Convert.ToDouble(str, numberFormatInfo);

            Console.WriteLine("Введите число 2");

            str = Console.ReadLine();

            
         

            b = Convert.ToDouble(str, numberFormatInfo);

            double result = a + b;

            Console.WriteLine("Сумма чисел = " + result);
        }
    }
}
