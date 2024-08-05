using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConversaoTemp.Conversor;

namespace ConversorTest
{
    public class Conversor
    {
        [Theory]
        [InlineData(25)]
        [InlineData(40)]
        public void ValidateConverterOfTempCelsiusToFahrenheit(double tempCelsius)
        {
            double tempFarenheit = ConvertTemp.ConvertCelsiusToFahrenheit(tempCelsius);

            Assert.Equal(tempFarenheit, 77);

        }

        [Theory]
        [InlineData(180)]
        [InlineData(260)]

        public void ValidateConverterOfTempFahrenheitToCelcius(double tempFahrenheit) 
        {
            double tempCelsius = ConvertTemp.ConvertFahrenheitToCelsius(tempFahrenheit);

            Assert.Equal(tempCelsius, 82);
        }
    }
}
