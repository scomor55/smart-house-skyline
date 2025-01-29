using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house.Models
{
    public interface IDevice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }

    }
}
