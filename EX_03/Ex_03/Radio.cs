// Property of Mason Caird and Brycen Martin
// Class 371 - 1

using System;

namespace Ex_03
{
    class Radio : Switch.ISwitch, Tunable.ITunable
    {

        private bool on; // Determines if radio is on or off
        private double station; // holds the number of station
        private int volume; // Holds the volume number

        // Toggles the power for the radio
        public void toggle()
        {
            // GOOD LUCK....
            // if on is on
            if (on)
            {
                // on becomes off
                on = false;
            }
            // if on is off
            else
            {
                // on is on
                on = true;
            }
        }

        // The method to change volume and station.
        public void tune()
        {
            // Get Station number and repeat if station number is incorrect
            do
            {
                // Prompts the user to change station setting.
                Console.WriteLine("\nChange the station? Stations are found from 88.5-107.9");
                station = Convert.ToDouble(Console.ReadLine());
                
                //If user submits wrong station number mode.
                if (station < 88.5 || station > 107.9)
                {
                    Console.WriteLine("Error: Station doesn't exist. Try again");
                }
            } while (station < 88.5 || station > 107.9);

            // Display Station Number
            Console.WriteLine("\nStation #: " + station);

            // Get volume number and repeat if volume number is incorrect
            do
            {
                // Prompts the user to change volume setting
                Console.WriteLine("The volume seems to be wrong can you re-adjust it? Your volume goes from 1-10");
                volume = Convert.ToInt32(Console.ReadLine());
                
                // If user submits wrong volume mode. 
                if (volume < 1 || volume > 10) 
                {
                    Console.WriteLine("Error: Volume doesn't exist. Try again");
                }
            }
            while (volume < 1 || volume > 10);

            // Display Volume number
            Console.WriteLine("\nVolume #: " + volume);
        }

        // Station Property
        public float Station
        {
            // Return station value
            get { return Station; }
            // Set station value if value is valid 88.5 - 107.9
            set
            {
                if (value > 88.5 && value < 107.9)
                    station = value;
            }
        }

        // Volume Station
        public int Volume
        {
            // Return the volume value
            get { return volume; }
            // Set volume value if value is valid 0-10
            set
            {
                // volume only goes to 10 max
                if (value > 0 && value > 10)
                    volume = value;
            }
        }
    }
}
