using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_4_сумма_и_количество_четных_и_нечетных_чисел
{
    internal class Program
    {
        /*
         * сумма и количество четных и нечетных чисел в диапазоне
         */
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;//нечетные числа
            uint evenNumbersCount = 0;//четные числа

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.WriteLine("Введите первое число диапазона");
            int currentValue = int.Parse(Console.ReadLine().Replace('.', ','));

            Console.WriteLine("Введите последнее число диапазона");
            int limit = int.Parse(Console.ReadLine().Replace('.', ','));
            

            while (currentValue <= limit)
            {
                if (currentValue%2==0)
                {
                    evenNumbersCount++;
                    evenNumbersSum = evenNumbersSum + currentValue;//можно записать
                   //evenNumbersSum += currentValue;
                }
                else

                {
                    oddNumbersCount++;
                    oddNumbersSum = oddNumbersSum + currentValue;
                    //можно и так oddNumbersSum += currentValue;
                }
                currentValue++;
            }

            Console.WriteLine("Количество нечетных чисел: " + oddNumbersCount);
            Console.WriteLine("Количество четных чисел: " + evenNumbersCount);

            Console.WriteLine("Сумма нечетных чисел: " + oddNumbersSum);
            Console.WriteLine("Сумма четных чисел: " + evenNumbersSum);
            Console.ReadLine();

        }
    }
}
