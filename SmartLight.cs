using System;
using System.Collections.Generic;
using System.Text;

namespace SHDMS
{
    public class SmartLight : SmartDevice, IBatteryPowered
    {
        public int Brightness {get; private set;}

        public SmartLight(string name, Manufacturer manufacturer, int brightness): base (name, manufacturer)
        {
            Brightness = brightness;
        }

        public void SetBrightness(int brightness)
        {
            Brightness = brightness;
        }

        public override string GetStatus() 
        {
            return $"Brightness: {Brightness}% | Power: {GetStatus}";
        }
    }
}
