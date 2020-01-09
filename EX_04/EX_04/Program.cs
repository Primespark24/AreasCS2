// Property Owners, Mason Caird Brycen Martin
// Class 371-1

// We realized that we spelled Celcius wrong when we were done with project. We didn't wanna make the change to mess up our code...
using System;

namespace EX_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //makes a new converter
            Converter c = new Converter();
            Conversion co = new Conversion();
            bool freeze = false;
            //messages for start of calculator
            Console.WriteLine("Welcome to Brycen and Mason's Temperature Calculator");
            Console.WriteLine("Press the enter button to continue!");
            Console.ReadLine();

            //infinite loop to run conversions as long as the user wants
            do
            {
                Console.WriteLine("Would you like to start the Temperature calculator? Yes, No");
                string answer = Console.ReadLine();
                //logic to determine if the user wants to use the calculator
                if (answer.ToLower().Contains("yes"))
                {

                    // We ask for number first because we don't know the reference of what you desire.
                    Console.WriteLine("Welcome to the Temperature Converter! To start give me a number.");
                    double temp = Convert.ToDouble(Console.ReadLine());

                    // We then ask for Temperature Label
                    Console.WriteLine("What is this Temperature in? Kelvin, Celcius, or Fahrenheit.");
                    string temptype = Console.ReadLine().ToLower();

                    // We show result of what we want to result.
                    Console.WriteLine("So the temperature to convert is " + temp + " " + temptype);
                    
                    //converter class method calls
                    c.VerifyTemp(temp, temptype);
                    c.TempColor(temp, temptype);

                    //how the converter decides which temperature scale to use

                    // Kelvin Conversion
                    if (temptype.ToLower().Contains("kelvin"))
                    {
                        Console.WriteLine("What would you like to convert your temperature to? Kelvin, Celcius, Fahrenheit");
                        string choice = Console.ReadLine();

                        //Calls function to convert
                        co.Calc(choice, temp, c);
                    }
                    // Celcius Conversion
                    else if (temptype.ToLower().Contains("celcius"))
                    {
                        Console.WriteLine("What would you like to convert your temperature to? Celcius, Kelvin, or Fahrenheit.");
                        string choice = Console.ReadLine();

                        //Calls function to convert
                        co.Calc(choice, temp, c);
                        
                    }
                    // Fahrenheit Conversion
                    else if (temptype.ToLower().Contains("fahrenheit"))
                    {
                        Console.WriteLine("What would you like to convert your temperature to? Celcius, or Kelvin.");
                        string choice = Console.ReadLine();

                        //Calls function to convert
                        co.Calc(choice, temp, c);
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
