using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace выписка_из_урока_конвертер_валют
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double UsdtoRub = 66.29;
            double UsdtoEuo = 10.11;
            double USD;

            Console.WriteLine("Введите сумму в USD ");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD в RUB = " + USD * UsdtoRub);

            Console.WriteLine(USD + " USD в Euo = " + USD * UsdtoEuo);
        }
    }
}
