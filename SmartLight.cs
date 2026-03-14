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
        SmartLight livingRoomLight = new SmartLight("Living Room", Manufacturer.philips, 80);

        SmartLight kitchenLight = new SmartLight("Kitchen Light", lifx, 65);

        SmartLight bedroomLight = new SmartLight("Bedroom Light", philips, 50);

        SmartLight gamingRoomLight = new SmartLight("Gaming Room Light", nanoleaf, 90);

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
