using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext__and_LINQ
{
    public delegate bool SearchCondition(double d);
    class Finder
    {

        // Написать методы поиска элемента в массиве (например, поиск всех положительных элементов в массиве) в виде:
        //  метода, реализующего поиск напрямую;
        public double[] MemberFind(double[] arr)
        {
            List<double> tmp = new List<double>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    tmp.Add(arr[i]);
                }
            }
            return tmp.ToArray();
        }

        // Написать методы поиска элемента в массиве (например, поиск всех положительных элементов в массиве) в виде:
         //метода, которому условие поиска передается через делегат;
        public double[] DelegateFind(double[] arr, SearchCondition condition)
        {
            List<double> tmp = new List<double>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (condition(arr[i]))
                {
                    tmp.Add(arr[i]);
                }
            }
            return tmp.ToArray();
        }

        public double[] LinqFind(double[] arr)
        {
            var result = from d in arr
                where d > 0
                select d;
                            
            return result.ToArray();
        }
    }
}
