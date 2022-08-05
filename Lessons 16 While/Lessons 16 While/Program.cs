using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_16_While
{
    /*
     * цикл while
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            double count = 0;
            double limit = Double.Parse(Console.ReadLine().Replace('.',','));

            while (count < limit)
            {
                count++;
                Console.WriteLine(count);
            }
        }
    }
}
