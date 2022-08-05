using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = USQLCSharpProject1_создание_проекта.MyLibrary.Multiply(3,5);
            double result1 = USQLCSharpProject1_создание_проекта.MyLibrary.Divide(9,0);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadLine();

                                
        }
    }
}
