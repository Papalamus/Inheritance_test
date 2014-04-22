using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext__and_LINQ
{
    class Program
    {
        private static void Main(string[] args)
        {
            Test t = new Test();
            Finder f = new Finder();
            //метода, реализующего поиск напрямую;
            double result = t.MeasureSpeed(f.MemberFind);
            Console.WriteLine("Простой метод поиска  {0}", result);

            //метода, которому условие поиска передается через делегат;
            result = t.MeasureSpeed(f.DelegateFind, IsPositive);
            Console.WriteLine("Через делегат  {0}", result);

            //метода, которому условие поиска передается через делегат в виде анонимного метода;
            result = t.MeasureSpeed(f.DelegateFind, delegate(double d)
            {
                return d > 0;
            });
            Console.WriteLine("Через анонимный метод {0}", result);

            //метода, которому условие поиска передается через делегат в виде лямбда-выражения;
            result = t.MeasureSpeed(f.DelegateFind, (d) => d > 0);
            Console.WriteLine("В виде лямбда-выражения = {0}", result);

            //LINQ-выражения;
            result = t.MeasureSpeed(f.LinqFind);
            Console.WriteLine("В виде LINQ-выражения = {0}", result);

            Console.ReadKey();
        }

        public static bool IsPositive(double d)
        {
            return d > 0;
        }
    }
}
