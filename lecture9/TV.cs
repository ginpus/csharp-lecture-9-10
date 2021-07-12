using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9
{
    internal class TV
    {
        private int MaxSound = 500;
        private int MaxResolution = 1080;
        private bool isOn = false;

        public void ToggleOnOff()
        {
            isOn = !isOn;
            if (isOn == true)
            {
                Console.WriteLine("TV is on");
            }
            else
            {
                Console.WriteLine("TV is off");
            }
        }
    }
}