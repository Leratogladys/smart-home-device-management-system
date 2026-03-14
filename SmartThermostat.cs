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

        SmartThermostat hallwayThermostat = new SmartThermostat("Hallway Thermostat", Manufacturer.nest, 21.5, 70);

        SmartThermostat bedroomThermostat = new SmartThermostat("Bedroom Thermostat", ecobee, 20.0, 85);

        SmartThermostat officeThermostat = new SmartThermostat("Office Thermostat", nest, 22.0, 60);


        public void SetTemperature(double temperature)
        {
            Temperature = temperature;
        }

        public override string GetStatus()
        {
            return $"Temperature: {Temperature}°C  Battery: {BatteryLevel}% | Power: {GetPowerStatus}";
        }

        public string Charge()
        {
            BatteryLevel = 100;
            return "Thermostat fully charged.";
        }

    }
}
