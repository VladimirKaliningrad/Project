using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*инкремент и декремент. Постфиксный и префиксный.
 */
namespace Lessons11_инкремент_и_декремент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            a = a++ * a;


            Console.WriteLine(a);


        }
    }
}
