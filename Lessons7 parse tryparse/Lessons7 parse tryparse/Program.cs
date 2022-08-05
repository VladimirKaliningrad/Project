using System;
using System.Globalization;


/*конвертация строки
 * parse and tryparse
 */

namespace Lessons7_parse_tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "1484.3";

            int a;

            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("Операция успешна, значение = " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }

           

            

        }
    }
}
