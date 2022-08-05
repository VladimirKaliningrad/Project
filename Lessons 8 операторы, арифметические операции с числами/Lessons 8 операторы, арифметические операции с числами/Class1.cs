using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_8_операторы__арифметические_операции_с_числами
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double firstvalue, secondvalue, thirvalue;

            Console.WriteLine("Введите число 1");

            firstvalue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");

            secondvalue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 3");

            thirvalue = double.Parse(Console.ReadLine());

            double sumresult = (firstvalue + secondvalue + thirvalue);

            double multresult = (firstvalue * secondvalue * thirvalue);

            Console.WriteLine("сумма трех чисел = " + sumresult);

            Console.WriteLine("Произведение трех чисел =" + multresult);
        }
    }
}
