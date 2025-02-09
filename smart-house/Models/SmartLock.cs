using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public class SmartLock : SmartDevice
    {

        public SmartLock(int id, string name): base(id,name){
            IsLocked = false;
            PinCode = "0000";
            BatteryLevel = 100;
        }

        public bool IsLocked { get; set; }
        public string PinCode { get; set; }
        public int BatteryLevel { get; set; }
    }
}
