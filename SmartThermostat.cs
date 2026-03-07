using System;
using System.Collections.Generic;
using System.Text;

namespace SHDMS
{
    public class SmartThermostat : SmartDevice, IBatteryPowered
    {
        public double Temperature { get; private set; }
        public int BatteryLevel { get; private set; }

        public SmartThermostat(string name, Manufacturer manufacturer, double temperature, int batteryLevel)
                           : base(name, manufacturer)
        {
            Temperature = temperature;
            BatteryLevel = batteryLevel;
        }

        public void SetTemperature(double temperature)
        {
            Temperature = temperature;
        }

        public override string GetStatus()
        {
            return $"Temperature: {Temperature} " + $" | Power: {GetPowerStatus}";
        }

        public string Charge()
        {
            BatteryLevel = 100;
            return "Thermostat fully charged.";
        }

    }
}
