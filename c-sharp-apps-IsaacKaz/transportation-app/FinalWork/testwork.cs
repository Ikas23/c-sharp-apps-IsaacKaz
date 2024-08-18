using c_sharp_apps_IsaacKaz.transportation_app;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class TestWork
    {
        public void testFinal()
        {
            // Set up the environment
            Driver driver1 = new Driver("John", "Doe", "1234", CargoType.Truck);
            Driver driver2 = new Driver("Jane", "Smith", "5678", CargoType.Plane);

            Port port1 = new Port("Port 1", "CountryA", "CityA", "StreetA", 1, 10000, 5000);
            Port port2 = new Port("Port 2", "CountryB", "CityB", "StreetB", 2, 20000, 10000);

            // Instantiate CargoVehicles with correct parameters
            Train train = new Train(driver1, 30000, 20000, false, false, port1, port2, 1, new List<IPortable>(), new Dictionary<string, decimal>(), 500, null, 10, 10);
            Plane plane = new Plane(driver2, 10000, 5000, false, false, port2, port1, 2, new List<IPortable>(), new Dictionary<string, decimal>(), 1000, null, null);
            Ship ship = new Ship(driver1, 50000, 30000, false, false, port1, port2, 3, new List<IPortable>(), new Dictionary<string, decimal>(), 800, null);

            // Create items to test loading and unloading
            IPortable item1 = new Chair("Red", 100m, "Wood", 50m, 40m, 500m, true);
            IPortable item2 = new Chair("Blue", 200m, "Metal", 70m, 60m, 1000m, false);

            // Test Train Loading
            Console.WriteLine("Test-1: Train Loading");
            train.LoadCargo(new List<IPortable> { item1, item2 });
            if (train.GetCurrentWeight() == 1500 && train.GetCurrentVolume() == 3000)
            {
                Console.WriteLine("Test-1 Success");
            }
            else
            {
                Console.WriteLine("Test-1 Failed");
            }

            // Test Train Travel
            Console.WriteLine("Test-2: Train Travel");
            train.ApproveForTravel();
            train.TravelToNextPort();
            if (train.CurrentPort == port2 && train.NextPort == null)
            {
                Console.WriteLine("Test-2 Success");
            }
            else
            {
                Console.WriteLine("Test-2 Failed");
            }

            // Test Train Unloading
            Console.WriteLine("Test-3: Train Unloading");
            train.UnloadCargo(new List<IPortable> { item1, item2 });
            if (train.GetCurrentWeight() == 0 && train.GetCurrentVolume() == 0)
            {
                Console.WriteLine("Test-3 Success");
            }
            else
            {
                Console.WriteLine("Test-3 Failed");
            }

            // Test Plane Loading
            Console.WriteLine("Test-4: Plane Loading");
            plane.LoadCargo(new List<IPortable> { item1, item2 });
            if (plane.StorageRoom.GetCurrentWeight() == 1500 && plane.StorageRoom.GetCurrentVolume() == 3000)
            {
                Console.WriteLine("Test-4 Success");
            }
            else
            {
                Console.WriteLine("Test-4 Failed");
            }

            // Test Plane Travel
            Console.WriteLine("Test-5: Plane Travel");
            plane.ApproveForTravel();
            plane.TravelToNextPort();
            if (plane.CurrentPort == port1 && plane.NextPort == null)
            {
                Console.WriteLine("Test-5 Success");
            }
            else
            {
                Console.WriteLine("Test-5 Failed");
            }

            // Test Plane Unloading
            Console.WriteLine("Test-6: Plane Unloading");
            plane.UnloadCargo(new List<IPortable> { item1, item2 });
            if (plane.StorageRoom.GetCurrentWeight() == 0 && plane.StorageRoom.GetCurrentVolume() == 0)
            {
                Console.WriteLine("Test-6 Success");
            }
            else
            {
                Console.WriteLine("Test-6 Failed");
            }

            // Test Ship Loading
            Console.WriteLine("Test-7: Ship Loading");
            ship.LoadContainers(new List<IContainable> { plane.StorageRoom });
            if (ship.Containers.Count == 1)
            {
                Console.WriteLine("Test-7 Success");
            }
            else
            {
                Console.WriteLine("Test-7 Failed");
            }

            // Test Ship Travel
            Console.WriteLine("Test-8: Ship Travel");
            ship.ApproveForTravel();
            ship.TravelToNextPort();
            if (ship.CurrentPort == port2 && ship.NextPort == null)
            {
                Console.WriteLine("Test-8 Success");
            }
            else
            {
                Console.WriteLine("Test-8 Failed");
            }

            // Test Ship Unloading
            Console.WriteLine("Test-9: Ship Unloading");
            ship.UnloadContainers();
            if (ship.Containers.Count == 0)
            {
                Console.WriteLine("Test-9 Success");
            }
            else
            {
                Console.WriteLine("Test-9 Failed");
            }
        }
    }
}
