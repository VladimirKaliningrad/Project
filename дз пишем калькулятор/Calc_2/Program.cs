using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Введите число 1");
            firstValue = double.Parse(Console.ReadLine().Replace('.',','));

            Console.WriteLine("Введите число 2");
            secondValue = double.Parse(Console.ReadLine().Replace('.',','));

            Console.WriteLine("Введите операцию: '+' '-' '*' '/'");
            action = Console.ReadLine();

            if (action == "+")
            {
                Console.WriteLine(firstValue + secondValue);
            }
            else if (action == "-")
            {
                Console.WriteLine(firstValue - secondValue);
            }
            else if (action == "*")
            {
                Console.Write(firstValue * secondValue);
            }
            else if (action == "/")
            {
                if (secondValue == 0)
                Console.WriteLine (0);
                
                else
                Console.Write(firstValue / secondValue);
            }
            else
            {
                Console.WriteLine("Ошибка! Неизвестное действий!");
            }

            Console.ReadLine();
        }
    }
}
