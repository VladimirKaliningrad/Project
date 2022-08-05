using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_14__логические_операторы
/*
 Логические операторы

    &&  сокращенное и
    ||  сокращенное ИЛИ
     &  И
     |  ИЛИ
     !  НЕ (унарный)
 */
{
    internal class Program
    {
                            //int fanSpeed = -1;

         public static bool GetTemperature()   
        {
            return false;
        }
         public static bool GetCoolingStatus ()

            {
             return true;
                        }

        static void Main(string[] args )
        {
            if (GetTemperature() & GetCoolingStatus ())

            {
                Console.WriteLine("Угроза повреждения процессора !!!");
            }




        }

           

           



        }
    }

