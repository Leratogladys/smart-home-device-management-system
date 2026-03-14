using System;
using System.Collections.Generic;
using System.Text;

namespace SHDMS 
{
    public class SmartDoorLock : SmartDevice, IBatteryPowered
    {
        public bool IsLocked {  get; private set; }
        public int BatteryLevel { get; private set; }

        public Manufacturer yale {  get; set; }
        public SmartDoorLock(string name, Manufacturer manufacturer, int batteryLevel,
                             bool isLocked = false): base(name, manufacturer)
        {
            IsLocked = false;
            BatteryLevel = batteryLevel;
        }

        SmartDoorLock frontDoorLock = new SmartDoorLock("Front Door Lock", yale, 75, true);

        SmartDoorLock backDoorLock = new SmartDoorLock("Back Door Lock", august, 50, false);

        SmartDoorLock garageDoorLock = new SmartDoorLock("Garage Door Lock", yale, 40, true);



        public void ToggleLock()
        {
            IsLocked = !IsLocked;
        }

        public override string GetStatus()
        {
            string lockState = IsLocked ? "Locked" : "Unlocked";

            return $"Lock: {lockState} | Battery: {BatteryLevel}% | Power: {GetPowerStatus}";
        }

        public string Charge()
        {
            BatteryLevel = 100;
            return "Door lock fully charged.";
        }

    }
}
