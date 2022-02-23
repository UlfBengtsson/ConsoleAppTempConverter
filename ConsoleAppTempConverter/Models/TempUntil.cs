using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTempConverter.Models
{
    public class TempUntil
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }
    }
}
