using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace EX_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //makes a new converter
            Converter c = new Converter();
            bool freeze = false;
            //messages for start of calculator
            Console.WriteLine("Welcome to Brycen and Mason's Temperature Calculator");
            Console.WriteLine("Press any button to continue!");
            Console.ReadLine();

            //infinite loop to run conversions as long as the user wants
            do
            {
                Console.WriteLine("Would you like to start the Temperature calculator? Yes, No");
                string answer = Console.ReadLine();
                //logic to determine if the user wants to use the calculator
                if (answer.ToLower().Contains("yes"))
                {
                    Console.WriteLine("Welcome to the Temperature Converter! To start give me a number.");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is this Temperature in? Kelvin, Celcius, or Fahrenheit.");
                    string temptype = Console.ReadLine().ToLower();
                    Console.WriteLine("So the temperature to convert is " + temp + " " + temptype);
                    
                    //converter class method calls
                    c.VerifyTemp(temp, temptype);
                    c.TempColor(temp, temptype);

                    //how the converter decides which temperature scale to use
                    if (temptype.ToLower().Contains("kelvin"))
                    {
                        Console.WriteLine(
                            "What would you like to convert your temperature to? Kelvin, Celcius, or Fahrenheit.");
                        string choice = Console.ReadLine();

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
                    }
                    else if (temptype.ToLower().Contains("celcius"))
                    {
                        Console.WriteLine(
                            "What would you like to convert your temperature to? Celcius, Kelvin, or Fahrenheit.");
                        string choice = Console.ReadLine();
                        if (choice.ToLower().Contains("kelvin"))
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
                    }
                    else if (temptype.ToLower().Contains("fahrenheit"))
                    {
                        Console.WriteLine("What would you like to convert your temperature to? Celcius, or Kelvin.");
                        string choice = Console.ReadLine();
                        if (choice.ToLower().Contains("celcius"))
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
                    }
                }
                else if(answer.ToLower().Contains("no"))
                {
                    //set freeze variable to true to enable the code to stop running
                    freeze = true;
                    Console.WriteLine("I guess you dont want to convert anymore. :(");
                }
            } while (freeze == false);
            
            //exit program
            Environment.Exit(0);
        }
    }
}
