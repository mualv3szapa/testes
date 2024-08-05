using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemp
{
    public static class Conversor
    {
        public class ConvertTemp
        {
            public static double ConvertCelsiusToFahrenheit (double tempCelsius)
            {
                return ((tempCelsius * 9) / 5) + 32;
            }

            public static double ConvertFahrenheitToCelsius ( double tempFahrenheit)
            {
                return ((tempFahrenheit - 32) / 9) * 5;
            }
        }
    }
}
