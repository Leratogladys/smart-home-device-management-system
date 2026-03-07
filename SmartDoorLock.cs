using System;
using System.Collections.Generic;
using System.Text;

namespace SHDMS 
{
    public class SmartDoorLock : SmartDevice, IBatteryPowered
    {
        public bool IsLocked {  get; private set; }
        public int BatteryLevel { get; private set; }


        public SmartDoorLock(string name, Manufacturer manufacturer, int batteryLevel,
                             bool isLocked = false): base(name, manufacturer)
        {
            IsLocked = false;
            BatteryLevel = batteryLevel;
        }


        public void ToggleLock()
        {
            IsLocked = !IsLocked;
        }

        public override string GetStatus()
        {
            return $"Brightness: {GetPowerStatus}% " + $" | Power: {GetStatus}";
        }

        public string Charge()
        {
            BatteryLevel = 100;
            return "Door lock fully charged.";
        }

    }
}
