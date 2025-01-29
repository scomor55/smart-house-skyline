using smart_house.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Services
{
    public interface IDeviceService<T> where T : Device
    {
        public bool turnOn(T device);
        public bool turnOff(T device);
        public string getStatus(T device);
    }
}
