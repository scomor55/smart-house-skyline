using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public class SmartLight : IDevice
    {

        public SmartLight(int id, string name) {
            Id = id; 
            Name = name;
            IsOn = false;
            Brightness = 0;
            Color = "White";
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public int Brightness { get; set; }
        public string Color { get; set; }

    }
}
