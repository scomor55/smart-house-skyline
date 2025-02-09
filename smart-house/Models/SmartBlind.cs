using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public class SmartBlind : SmartDevice
    {
        public SmartBlind(int id, string name) : base (id, name) {
            Position = 0;
            IsAutomatic = false;
            LightSensor = false;
        }

        public int Position { get; set; }
        public bool IsAutomatic { get; set; }
        public bool LightSensor { get; set; }

    }
}
