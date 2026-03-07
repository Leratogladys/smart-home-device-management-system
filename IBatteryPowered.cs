using System;
using System.Collections.Generic;
using System.Text;

namespace SHDMS
{
    public interface IBatteryPowered
    {
        int BatteryLevel { get; }

        //public virtual string GetBatteryLevel()
        //{
        //    return BatteryLevel;
        //}

        string Charge(string batteryLevel)
        {
         return batteryLevel;
        }
    }
}
