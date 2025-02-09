using smart_house.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Services
{
    public class SmartLightService : IDeviceService<SmartLight>
    {
        public bool TurnOn(SmartLight light)
        {
            if (!light.IsOn)
            {
                light.IsOn = true;
                return true;
            }
            return false;
        }

        public bool TurnOff(SmartLight light)
        {
            if (light.IsOn)
            {
                light.IsOn = false;
                return true;
            }
            return false;
        }

        public string GetStatus(SmartLight light) {
            if (light.IsOn) return "On";
            else return "Off";
        }

        public bool SetBrightness(SmartLight light, int level) {
            if (level >= 0 && level <= 100)
            {
                light.Brightness = level;
                return true;
            }

            return false;
        }

        public void ChangeColor(SmartLight light,string newColor)
        {
            light.Color = newColor.ToLower();
        }
    }
}
