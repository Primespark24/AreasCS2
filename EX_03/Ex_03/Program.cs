// Property of Mason Caird and Brycen Martin
// Class 371 - 1

using System;

namespace Ex_03
{
    class Program
    {

        static void Main(string[] args)
        {
            Radio r = new Radio();
            bool quit = false;
            bool radioStatus = false;
            string reportRadioStatus;
            
            // Header of program
            Console.WriteLine("Brycen's and Mason's Radio Simulator");
            
            do
            {
                // Determines radio status for user
                if (!radioStatus)
                {
                    reportRadioStatus = "Off";
                }
                else
                {
                    reportRadioStatus = "On";
                }
                
                Console.WriteLine("Radio Status: " + reportRadioStatus);

                Console.WriteLine("\nSwitch power on the radio? Yes or No");
                string choice = Console.ReadLine();

                // Radio is off but user turns on radio
                if (choice.ToLower().Contains("yes") && radioStatus == false)
                {
                    radioStatus = true;
                    r.toggle();
                    Console.WriteLine("\nYou hear the satisfying click of the switch and the static of the radio");
                    r.tune();
                }
                
                // Radio is off and user doesn't turn it on
                else if (choice.ToLower().Contains("no") && radioStatus == false)
                {
                    Console.WriteLine("Wanna Continue?");
                    string response = Console.ReadLine();

                    // If user answers no, quit becomes true and terminates the program
                    if (response.Contains("no"))
                    {
                        quit = true;
                    }
                }
                
                // Radio is on and user turns it off
                else if (choice.ToLower().Contains("yes") && radioStatus == true)
                {
                    // Radio is off
                    radioStatus = false;
                }
                
                // Radio is on and user leaves it on
                else if (choice.ToLower().Contains("no") && radioStatus == true)
                {
                    // ***ISSUE need to be fixed***
                    // We don't really know why r.tune() doesn't work again after running it the first time.
                    // The goal was to have the user run through the tune method again.
                    Console.WriteLine("Help!!!");
                    r.tune();
                }

                // Something happened that code can't read
                else
                {
                    Console.WriteLine("Error: Try a different input...");
                }

            } while (!quit);
        }
    }
}
