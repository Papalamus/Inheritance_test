using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Converter.Model
{
    

    public class ConverterLogic
    {
        public class Currency
        {
            public string Name { get; set; }
            public double ExchangeRate { get; set; }

            public Currency(string name, double exchangeRate)
            {
                Name = name;
                ExchangeRate = exchangeRate;
            }
        }

        public Currency[] Currencies
        {
            get { return currencies; }
        }

        private Currency[] currencies = new[]
        {
            new Currency("Рубли", 0.0298),
            new Currency("Евро", 1.369),
            new Currency("Франки", 1.095),
            new Currency("Йены", 0.963),
        };

        public double Exchange(double ammount, double fromCourse, double toCourse)
        {
            return ammount*fromCourse/toCourse;
        }

    }
}