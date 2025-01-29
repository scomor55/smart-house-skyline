using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public class SmartBlinds : IDevice
    {
        public SmartBlinds(int id, string name) {
            Id = id;
            Name = name;
            Position = 0;
            IsAutomatic = false;
            LightSensor = false;
        }

        
        public int Id { get; set; }
        public string Name {  get; set; }
        public bool IsOn { get; set; }

        public int Position { get; set; }
        public bool IsAutomatic { get; set; }
        public bool LightSensor { get; set; }


    }
}
