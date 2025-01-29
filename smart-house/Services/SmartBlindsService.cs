using smart_house.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Services
{
    public class SmartBlindsService : IDeviceService<SmartBlinds>
    {
        public bool TurnOn(SmartBlinds smartBlind)
        {
            if (!smartBlind.IsOn)
            {
                smartBlind.IsOn = true;
                return true;
            }
            return false;
        }

        public bool TurnOff(SmartBlinds smartBlind)
        {
            if (smartBlind.IsOn)
            {
                smartBlind.IsOn = false;
                return true;
            }
            return false;
        }

        public string GetStatus(SmartBlinds smartBlind)
        {
            if (smartBlind.IsOn) return "On";
            else return "Off";
        }

        public void OpenBlinds(SmartBlinds smartBlind) {
            smartBlind.Position = 100;
        }

        public void CloseBlinds(SmartBlinds smartBlind)
        {
            smartBlind.Position = 0;
        }

        public void SetPosition(SmartBlinds smartBlind, int position)
        {
            smartBlind.Position = position;
        }

        public void EnableAutoMode(SmartBlinds smartBlind)
        {
            smartBlind.IsAutomatic = true;
        }

        public void AdjustToLightLevel(SmartBlinds smartBlind)
        {
            smartBlind.LightSensor = true;
        }
    }

}
