using smart_house.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Services
{
    public class SmartLockService : IDeviceService<SmartLock>
    {
        public bool TurnOn(SmartLock smartLock)
        {
            if (!smartLock.IsOn)
            {
                smartLock.IsOn = true;
                return true;
            }
            return false;
        }

        public bool TurnOff(SmartLock smartLock)
        {
            if (smartLock.IsOn)
            {
                smartLock.IsOn = false;
                return true;
            }
            return false;
        }

        public string GetStatus(SmartLock smartLock)
        {
            if (smartLock.IsOn) return "On";
            else return "Off";
        }

        public void Lock(SmartLock smartLock)
        {
            if (!smartLock.IsLocked && smartLock.IsOn)
            {
                smartLock.IsLocked = true;
            }
        }

        public void Unlock(SmartLock smartLock, string pinCode)
        {
            if (smartLock.IsOn && smartLock.IsLocked && smartLock.PinCode == pinCode)
            {
                smartLock.IsLocked = false;
            }
        }

        public void ChangePin(SmartLock smartLock, string oldPinCode, string newPinCode)
        {
            if (smartLock.IsOn && smartLock.PinCode == oldPinCode)
            {
                smartLock.PinCode = newPinCode;
            }
        }

        public int CheckBattery(SmartLock smartLock)
        {
            return smartLock.BatteryLevel;
        }
    }
}
