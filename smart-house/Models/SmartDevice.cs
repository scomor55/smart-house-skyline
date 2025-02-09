using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public abstract class SmartDevice : IDevice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }

        protected SmartDevice(int id, string name) {
            Id = id;
            Name = name;
            IsOn = false;
        }
    }
}
