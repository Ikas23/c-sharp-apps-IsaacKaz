using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class Driver
    {
   
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Id { get; set; }
            public CargoType DriverType { get; set; }

            public Driver(string firstName, string lastName, string id, CargoType driverType)
            {
                FirstName = firstName;
                LastName = lastName;
                Id = id;
                DriverType = driverType;
            }

            public void Approve(CargoVehicle vehicle)
            {
                vehicle.IsReadyToDrive = true;
            }
        
    }
}
