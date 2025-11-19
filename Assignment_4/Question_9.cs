using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Question_9
    {
        // Delegate that accepts a double and returns double
        public delegate double ConvertTemperature(double celsius);

        class TemperatureConverter
        {
            public double CelsiusToFahrenheit(double c)
            {
                return (c * 9 / 5) + 32;
            }

            public double CelsiusToKelvin(double c)
            {
                return c + 273.15;
            }
        }

        static void Main(string[] args)
        {
            TemperatureConverter tc = new TemperatureConverter();

            ConvertTemperature converter;  // delegate variable

            double temp = 25;   // given temperature

            // Celsius → Fahrenheit
            converter = tc.CelsiusToFahrenheit;
            Console.WriteLine("25°C in Fahrenheit = " + converter(temp));

            // Celsius → Kelvin
            converter = tc.CelsiusToKelvin;
            Console.WriteLine("25°C in Kelvin = " + converter(temp));
        }
    }
}
