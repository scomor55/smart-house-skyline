using smart_house.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public class SmartThermostat : IDevice
    {
        public SmartThermostat(int id, string name) {
            Id = id;
            Name = name;
            IsOn = false;
            CurrentTemperature = 20;
            TargetTemperature = 20;
            Mode = ThermostatMode.Off;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public int CurrentTemperature { get; set; }
        public int TargetTemperature { get; set; }
        public ThermostatMode Mode { get; set; }
    }
}
