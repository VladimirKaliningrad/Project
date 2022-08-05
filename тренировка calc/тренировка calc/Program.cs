using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тренировка_calc
{
    internal class Program
    {
        const string PASSWORD = "111123";
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль!");
            string pass = Console.ReadLine();

            if (PASSWORD != pass)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильный пароль!");
                Console.ReadLine();
                return;
          
            
             }
        
        
        Console.Clear();
            Console.ReadLine();

            Console.WriteLine("Введите пароль!");
            string pas = Console.ReadLine();

            const string PASSWOR = "12345";
            
            
            if (PASSWORD != pass)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели неправильный пароль!");
                Console.ReadLine();
                return;


            }
            Console.ReadLine();

        
        }


        

    }
}
