using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя");
            string username = Console.ReadLine();
            Console.WriteLine("Hello, ");
            Console.Write(username);
            int numberA = new Random ().Next(1,10);// 1 2 3 4 5 ....9
            Console.WriteLine(numberA);
            
            int numberB = new Random().Next(1,10);
            Console.WriteLine(numberB);
            int result = numberA + numberB;
            Console.WriteLine(result);
        }
    }
}
