using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public class SmartLight : SmartDevice
    {

        public SmartLight(int id, string name) : base(id,name){
            Brightness = 0;
            Color = "White";
        }

        public int Brightness { get; set; }
        public string Color { get; set; }

    }
}
