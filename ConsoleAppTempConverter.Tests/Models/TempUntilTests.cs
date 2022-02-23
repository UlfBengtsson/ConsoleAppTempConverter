using ConsoleAppTempConverter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleAppTempConverter.Tests.Models
{
    public class TempUntilTests
    {
        /*
            Kelvin      Celsius     Fahrenheit      Comment
          -------------------------------------------------------------------
            0      K    -273.15°C   -459.67 °F      Absolute zero point
            233.15 K    -40°C       -40 °F
            273.15 K    0°C         32 °F
            293.15 K	20°C	    68.0 °F
            310.15 K	37°C    	98.6 °F         Normal body temperature
            373.15 K	100°C   	212.0 °F        Boiling point of water
          --------------------------------------------------------------------
        */

        [Fact]
        public void ZeroCelsiusToFahrenheitTest()
        {
            //Arrange
            double celsius = 0.0;
            double fahrenheit = 32.0;
            TempUntil tempUntil = new TempUntil();

            //Act
            double result = tempUntil.CelsiusToFahrenheit(celsius);

            //Assert
            Assert.Equal(fahrenheit, result);
        }

        [Fact]
        public void NegativFortyCelsiusToFahrenheitTest()
        {
            //Arrange
            double celsius = -40.0;
            double fahrenheit = -40.0;
            TempUntil tempUntil = new TempUntil();

            //Act
            double result = tempUntil.CelsiusToFahrenheit(celsius);

            //Assert
            Assert.Equal(fahrenheit, result);
        }

        [Fact]
        public void AbsoluteZeroCelsiusToFahrenheitTest()
        {
            //Arrange
            double celsius = -273.15;
            double fahrenheit = -459.67;
            TempUntil tempUntil = new TempUntil();

            //Act
            double result = tempUntil.CelsiusToFahrenheit(celsius);

            //Assert
            Assert.Equal(fahrenheit, result, 2);

            /*
            Assert.Equal(fahrenheit, result);
              Assert.Equal() Failure
                Expected: -459,67
                Actual:   -459,66999999999996
            */
        }

        [Theory]
        [InlineData(-459.67, -273.15)]
        [InlineData(-40, -40)]
        [InlineData(32,0)]
        [InlineData(68.0, 20)]
        public void FahrenheitToCelsiusTest(double fahrenheit, double expectedCelsius)
        {
            //Arrange
            TempUntil tempUntil = new TempUntil();

            //Act
            double result = tempUntil.FahrenheitToCelsius(fahrenheit);

            //Assert
            Assert.Equal(expectedCelsius, result, 2);
        }
    }
}
