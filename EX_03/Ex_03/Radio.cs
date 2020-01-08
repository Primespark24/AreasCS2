using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Radio : Switch.ISwitch, Tunable.ITunable
    {
        private bool on;
        private double station;
        private int volume;
        private bool retune;
        private bool soundwaves;
        public void toggle()
        {
            
            if (on)
            {
                on = false;
            }
            else
            {
                on = true;
            }
        }

        public void tune()
        {
            do
            {
                if (station < 88.5 || station > 107.9)
                {
                    retune = true;
                    Console.WriteLine("So you want to change the station? stations found from 88.5-107.9");
                    station = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(station);
                }
                else
                {
                    retune = false;
                }

            } while (station < 88.5 || station > 107.9);

            do
            {
                if (volume < 1 || volume > 10) 
                {
                    soundwaves = true;
                    Console.WriteLine("The volume seems to be wrong can you re-adjust it? Your volume goes from 1-10");
                    volume = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(volume);
                }
                else
                {
                    soundwaves = false;
                }
            }
            while (volume < 1 || volume > 10);
        }

        public float Station
        {
            get { return Station; }
            set
            {
                if (value > 88.5 && value < 107.9)
                    station = value;
            }
        }

        public int Volume
        {
            get { return volume; }
            set
            {
                // volume only goes to 10 max
                if (value > 0 && value > 10)
                    volume = value;
            }
        }
    }
}
