using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тренировка_урок_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;


            int b = 5;

            Console.WriteLine(a >= b);
            Console.WriteLine(a != b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);

            Console.WriteLine ("Введите число 1 ");
            double c = Convert.ToDouble(Console.ReadLine().Replace(".",","));
            Console.WriteLine("Введите число 2 ");
            double d = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            double result = (c + d)/2;
            Console.Write("Решение " + result);



            







        }
    }
}
