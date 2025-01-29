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
        public bool turnOn(SmartLight light)
        {
            if (!light.IsOn)
            {
                light.IsOn = true;
                return true;
            }
            return false;
        }

        public bool turnOff(SmartLight light)
        {
            if (light.IsOn)
            {
                light.IsOn = false;
                return true;
            }
            return false;
        }

        public string getStatus(SmartLight light) {
            if (light.IsOn) return "On";
            else return "Off";
        }

        public void setBrightness(SmartLight light, int level) {
            if(level >= 0 &&  level <= 100) light.brightness = level;
        }

        public void changeColor(SmartLight light,string newColor)
        {
            light.color = newColor.ToLower();
        }
    }
}
