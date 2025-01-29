using smart_house.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Services
{
    public interface IDeviceService<T> where T : IDevice
    {
        public bool TurnOn(T device);
        public bool TurnOff(T device);
        public string GetStatus(T device);
    }
}
