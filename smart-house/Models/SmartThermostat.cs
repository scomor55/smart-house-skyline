using smart_house.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public class SmartThermostat : SmartDevice
    {
        public SmartThermostat(int id, string name) : base(id,name) {
            CurrentTemperature = 20;
            TargetTemperature = 20;
            Mode = ThermostatMode.Auto;
        }
        public int CurrentTemperature { get; set; }
        public int TargetTemperature { get; set; }
        public ThermostatMode Mode { get; set; }
    }
}
