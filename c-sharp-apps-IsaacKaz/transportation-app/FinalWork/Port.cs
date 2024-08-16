using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class Port : StorageStructure
    {
        public string PortName { get; set; }
        public StorageStructure[] Warehouses { get; set; }
        public Port(string portName, string country, string city, string street, int number, decimal maxVolume, decimal maxWeight)
            :base(country, city, street, number, maxVolume,
             maxWeight ,0, 0, new List<IPortable> { })
        {
            PortName = portName;
        }
     

    }
}
