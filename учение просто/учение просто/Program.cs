using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace учение_просто
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            int temp = a % 2;

            bool result = temp == 0;

            if (a % 2 == 0)
            {
                Console.WriteLine("число четное");
             }
            else
            {
                Console.WriteLine("число нечетное");
            }


        }
    }
}



