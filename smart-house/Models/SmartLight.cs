using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public class SmartLight : Device
    {

        public SmartLight(int id, string name) {
            Id = id; 
            Name = name;
            IsOn = false;
            brightness = 0;
            color = "White";
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public int brightness { get; set; }
        public string color { get; set; }

    }
}
