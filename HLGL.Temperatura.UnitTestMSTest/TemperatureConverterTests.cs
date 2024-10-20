using Microsoft.VisualStudio.TestTools.UnitTesting;
using HLGL.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLGL.Temperatura.Tests
{
    [TestClass]
    public class TemperatureConverterTests
    {
        [TestMethod]
        public void CelsiusToFahrenheit_ConvertsCorrectly()
        {
            // Arrange
            TemperatureConverter temperatureConvert = new TemperatureConverter();
            double celsius = 0; // 0°C should be 32°F
            double expectedFahrenheit = 32;

            // Act
            double actualFahrenheit = temperatureConvert.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expectedFahrenheit, actualFahrenheit, 0.001, "Conversion from Celsius to Fahrenheit is incorrect.");
        }

        [TestMethod]
        public void FahrenheitToCelsius_ConvertsCorrectly()
        {
            // Arrange
            TemperatureConverter temperatureConvert = new TemperatureConverter();
            double fahrenheit = 32; // 32°F should be 0°C
            double expectedCelsius = 0;

            // Act
            double actualCelsius = temperatureConvert.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expectedCelsius, actualCelsius, 0.001, "Conversion from Fahrenheit to Celsius is incorrect.");
        }
    }
}