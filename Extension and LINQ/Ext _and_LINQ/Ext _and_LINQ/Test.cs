using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext__and_LINQ
{
    class Test
    {
        private const int measurings = 15;
        private const int arrLength = 1500000;
        private double[] _testArray =new double[arrLength];

        public Test()
        {
            Random r = new Random();
            for (int i = 0; i < arrLength; i++)
            {
                _testArray[i] = r.NextDouble();
            }
            
        }

        public double MeasureSpeed(Func<double[],double[]> method)
        {
            double average = 0;

            for (int i = 0; i < measurings; i++)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                method(_testArray);

                stopwatch.Stop();
                average += stopwatch.ElapsedMilliseconds / measurings;
            }
            return average;
        }

        public double MeasureSpeed(Func<double[], SearchCondition, double[]> method, SearchCondition condition)
        {
            double average = 0;

            for (int i = 0; i < measurings; i++)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                method(_testArray, condition);

                stopwatch.Stop();
                average += stopwatch.ElapsedMilliseconds / measurings;
            }
            return average;
        }
    }
}
