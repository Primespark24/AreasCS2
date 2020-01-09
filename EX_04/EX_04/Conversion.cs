// Property Owners, Mason Caird Brycen Martin
// Class 371-1
using System;


namespace EX_04
{
    class Conversion
        {
            public void Calc(string choice, double temp, Converter c)
            {
                //logic for which temperature scale to convert to
                if (choice.ToLower().Contains("celcius"))
                {
                    c.KelvinToCelciusConversion(temp);
                }
                else if (choice.ToLower().Contains("fahrenheit"))
                {
                    c.KelvinToFahrenheitConversion(temp);
                }
                else if (choice.ToLower().Contains("kelvin"))
                {
                    c.KelvinToKelvinConversion(temp);
                }
                else if (choice.ToLower().Contains("kelvin"))
                {
                    c.CelciusToKelvinConversion(temp);
                }
                else if (choice.ToLower().Contains("fahrenheit"))
                {
                    c.CelciusToFahrenheitConversion(temp);
                }
                else if (choice.ToLower().Contains("celcius"))
                {
                    c.CelciusToCelciusConversion(temp);
                }
                else if (choice.ToLower().Contains("celcius"))
                {
                    c.FahrenheitToCelciusConversion(temp);
                }
                else if (choice.ToLower().Contains("kelvin"))
                {
                    c.FahrenheitToKelvinConversion(temp);
                }
                else if (choice.ToLower().Contains("fahrenheit"))
                {
                    c.FahrenheitToFahrenheitConversion(temp);
                }
                else
                {
                    Console.WriteLine("Error: No valid Input");
                }
            }
    }
}
