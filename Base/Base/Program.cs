using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 6;
            int d = 8;
            int e = 4;

            int max = a;

            if (a > max) max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;


            Console.Write("max = ");
            Console.WriteLine(max);


        }
    }
}
