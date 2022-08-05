using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace USQLCSharpProject1_создание_проекта
{
    public static class MyLibrary
    {
        public static double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        public static double Subtract(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
        //
        public static double Multiply (double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }

        public static double Divide (double firstValue, double secondValue)
        {
            if (secondValue == 0)
                return 0;

            return firstValue / secondValue;
        }
           
    }
}