using smart_house.Enums;
using smart_house.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Services
{
    public class SmartThermostatService : IDeviceService<SmartThermostat> 
    {

        public bool TurnOn(SmartThermostat thermostat)
        {
            if (!thermostat.IsOn)
            {
                thermostat.IsOn = true;
                return true;
            }
            return false;
        }

        public bool TurnOff(SmartThermostat thermostat)
        {
            if (thermostat.IsOn)
            {
                thermostat.IsOn = false;
                return true;
            }
            return false;
        }

        public string GetStatus(SmartThermostat thermostat)
        {
            if (thermostat.IsOn) return "On";
            else return "Off";
        }

        public void  SetTemperature(SmartThermostat thermostat, int temperature) {
            if (thermostat.IsOn) {
                thermostat.TargetTemperature = temperature;
            }
        }

        public void SwitchMode(SmartThermostat thermostat, ThermostatMode mode)
        {
            if (thermostat.IsOn)
            {
                thermostat.Mode = mode;
            }

        }
    }
}
