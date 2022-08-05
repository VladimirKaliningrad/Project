using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons18_цикл_for
{
    /*
     * цикл for
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit;i ++)
            {
                Console.WriteLine(i);
            }

            /*int i = 0;
             * while (i < limit)
             * {
             * Console.WriteLine (I);
             * i ++
             * }
             
             */

            

            
        }
    }
}
