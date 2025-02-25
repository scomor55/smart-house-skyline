﻿using smart_house.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Services
{
    public class SmartBlindService : IDeviceService<SmartBlind>
    {
        public bool TurnOn(SmartBlind smartBlind)
        {
            if (!smartBlind.IsOn)
            {
                smartBlind.IsOn = true;
                return true;
            }
            return false;
        }

        public bool TurnOff(SmartBlind smartBlind)
        {
            if (smartBlind.IsOn)
            {
                smartBlind.IsOn = false;
                return true;
            }
            return false;
        }

        public string GetStatus(SmartBlind smartBlind)
        {
            if (smartBlind.IsOn) return "On";
            else return "Off";
        }

        public void OpenBlind(SmartBlind smartBlind) {
            smartBlind.Position = 100;
        }

        public void CloseBlind(SmartBlind smartBlind)
        {
            smartBlind.Position = 0;
        }

        public bool SetPosition(SmartBlind smartBlind, int position)
        {
            if (position >= 0 && position <= 100) {
                smartBlind.Position = position;
                return true;    
            }
            return false;
        }

        public void EnableAutoMode(SmartBlind smartBlind)
        {
            smartBlind.IsAutomatic = true;
        }

        public void AdjustToLightLevel(SmartBlind smartBlind)
        {
            smartBlind.LightSensor = true;
        }
    }

}
