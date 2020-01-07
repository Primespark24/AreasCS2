using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Radio : ISwitch, ITunable
    {
        private bool on;
        private float station;
        private int volume;
        public void toggle()
        {
            if (on)
            {
                on = false;
            }else
            {
                on = true;
            }
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

        public int
    }
}
