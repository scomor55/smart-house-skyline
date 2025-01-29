using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public class SmartLock : IDevice
    {

        public SmartLock(int id, string name) {
            Id = id;
            Name = name;
            IsOn = false;
            IsLocked = false;
            PinCode = "0000";
            BatteryLevel = 100;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }

        public bool IsLocked { get; set; }
        public string PinCode { get; set; }
        public int BatteryLevel { get; set; }
    }
}
