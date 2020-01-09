using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_04
{
    class Converter
    {
        double convertedtemp = 0;
        public double CelciusToKelvinConversion(double tempCelcius)
        {
            convertedtemp = tempCelcius + 273.15;
            Console.WriteLine("Your temperature in Kelvin is " + convertedtemp);
            return 0;
        }

        public double CelciusToCelciusConversion(double tempCelcius)
        {
            Console.WriteLine("Your temperature in Celcius is " + tempCelcius);
            return 0;
        }

        public double CelciusToFahrenheitConversion(double tempCelcius)
        {
            convertedtemp = (tempCelcius * 1.8) + 32; 
            Console.WriteLine("Your temperature in Fahrenheit is " + convertedtemp);
            return 0;
        }

        public double FahrenheitToCelciusConversion(double tempFahrenheit)
        {
            convertedtemp = (tempFahrenheit - 32) * (0.55);
            Console.WriteLine("Your temperature in Celcius is " + convertedtemp);
            return 0;
        }
        public double FahrenheitToKelvinConversion(double tempFahrenheit)
        {
            convertedtemp = (tempFahrenheit - 32) * (0.55) + 273.15;
            Console.WriteLine("Your temperature in Kelvin is " + convertedtemp);
            return 0;
        }
        public double FahrenheitToFahrenheitConversion(double tempFahrenheit)
        {
            Console.WriteLine("Your temperature in Fahrenheit is " + tempFahrenheit);
            return 0;
        }
        public double KelvinToFahrenheitConversion(double tempKelvin)
        {
            convertedtemp = (tempKelvin - 273.15) * 1.8 + 32;
            Console.WriteLine("Your temperature in Fahrenhiet is " + convertedtemp);
            return 0;
        }
        public double KelvinToCelciusConversion(double tempKelvin)
        {
            convertedtemp = tempKelvin - 273.15;
            Console.WriteLine("Your temperature in Celcius is " + convertedtemp);
            return 0;
        }
        public double KelvinToKelvinConversion(double tempKelvin)
        {
            Console.WriteLine("Your temperature in Kelvin is " + tempKelvin);
            return 0;
        }
        public void VerifyTemp(double abstemp, string tempchoice)
        {
            try
            {
                //checks to see if temperature is lower than possible in fahrenheit
                if (abstemp < -459.67 && tempchoice.ToLower() == "fahrenheit")
                {
                    throw new ImpossibleException(
                        "ERROR: your temperature goes below the lowest temperature in the universe");
                }
                //checks to see if temperature is lower than possible in Kelvin
                else if (abstemp < 0 && tempchoice.ToLower() == "kelvin")
                {
                    throw new ImpossibleException(
                        "ERROR: your temperature goes below the lowest temperature in the universe");
                }
                //checks to see if temperature is lower than possible in celcius
                else if (abstemp < -273.15 && tempchoice.ToLower() == "celcius")
                {
                    throw new ImpossibleException(
                        "ERROR: your temperature goes below the lowest temperature in the universe");
                }
            }
            catch (ImpossibleException IE)
            {
                Console.WriteLine(IE.Message);
                Environment.Exit(0);
            }
        }

        //changes color of console if its above freezing for respective temperature
        public void TempColor(double heatmap, string tempside)
        {
            if (heatmap < 273.15 && tempside == "kelvin")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
            }
            else if(heatmap > 273.16 && tempside == "kelvin")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            
            if (heatmap < 0 && tempside == "celcius")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
            }
            else if (heatmap > 0.001 && tempside == "celcius")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
            }

            if (heatmap < 32 && tempside == "fahrenheit")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
            }
            else if (heatmap > 32.0001 && tempside == "fahrenheit")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
            }
        }
    }
}
