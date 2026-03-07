using System;
using System.Collections.Generic;
using System.Text;

namespace SHDMS
{
    public abstract class SmartDevice
    {
        public string DeviceName { get; set; }
        public Manufacturer Manufacturer { get; set; }

        private bool IsOn { get; set; }

        public SmartDevice(string deviceName, Manufacturer manufacturer)
        {
            DeviceName = deviceName;
            Manufacturer = manufacturer;
        }

        public void TurnOn()
        {
            IsOn = true;
        }

        public void TurnOff()
        {
            IsOn = false;
        }

        public string GetPowerStatus()
        {
            string status = "";

            if (IsOn == true)
            {
                status = "On";
            }
            else
            {
                status = "Off";
            }

            return status;
        }


        public abstract string GetStatus();

      
            
        
    }
}
