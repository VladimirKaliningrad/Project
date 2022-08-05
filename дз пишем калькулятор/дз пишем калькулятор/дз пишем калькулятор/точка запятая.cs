// Decompiled with JetBrains decompiler
// Type: Calc.Program
// Assembly: дз пишем калькулятор, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9648BC08-C22A-47E5-BB21-E67822635E06
// Assembly location: C:\Users\User\Desktop\Project\дз пишем калькулятор\дз пишем калькулятор\bin\Debug\дз пишем калькулятор.exe

using System;

namespace Calc
{
  internal class Program
  {
    

    private static void Main(string[] args)
    {
      
        while (true)
        {
          Console.Clear();
          double num1;
          double num2;
          try
          {
            Console.WriteLine("Введите число 1 ");
            num1 = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.WriteLine("Введите число 2 ");
            num2 = double.Parse(Console.ReadLine().Replace('.', ','));
          }
          catch (Exception ex)
          {
            Console.WriteLine("Не удалось преобразовать строку в число!");
            Console.ReadLine();
            continue;
          }
          Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
          string str = Console.ReadLine();
          if (!(str == "+"))
          {
            if (!(str == "-"))
            {
              if (!(str == "*"))
              {
                if (str == "/")
                {
                  if (num2 == 0.0)
                    Console.WriteLine(0);
                  else
                    Console.WriteLine(num1 / num2);
                }
                else
                  Console.WriteLine("Ошибка! Неизвестное действие!");
              }
              else
                Console.WriteLine(num1 * num2);
            }
            else
              Console.WriteLine(num1 - num2);
          }
          else
            Console.WriteLine(num1 + num2);
          Console.ReadLine().Replace('.', ',');
          Console.WriteLine();
        }
      
    }
  }
}
