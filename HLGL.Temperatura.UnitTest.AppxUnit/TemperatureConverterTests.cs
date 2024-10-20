using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLGL.Temperatura.UnitTest.AppxUnit
{
    public class TemperatureConverterTests
    {
        [Fact]
        public void ReverseString_InvertsStringCorrectly()
        {
            // Arrange
            StringManipulator stringManipulator = new StringManipulator();
            string input = "hello";
            string expected = "olleh";

            // Act
            string actual = stringManipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_RemovesSpacesCorrectly()
        {
            // Arrange
            StringManipulator stringManipulator = new StringManipulator();
            string input = "hello world";
            string expected = "helloworld";

            // Act
            string actual = stringManipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
