using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext__and_LINQ
{
    public static class ExtensionClass
    {
        //Напишите расширяющий метод, который определяет сумму элементов массива.
        public static double GetSum(this double [] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        //Напишите расширяющий метод, который определяет, является ли строка
        //положительным целым числом. Методы Parse и TryParse не использовать.
        public static bool IsNatural(this string s)
        {
            
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
