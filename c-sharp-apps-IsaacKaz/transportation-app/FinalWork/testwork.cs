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

            Driver driver1 = new Driver("John", "Doe", "1234", CargoType.Truck);
            Driver driver2 = new Driver("Jane", "Smith", "5678", CargoType.Plane);

            Port port1 = new Port("Port 1", "CountryA", "CityA", "StreetA", 1, 10000, 5000);
            Port port2 = new Port("Port 2", "CountryB", "CityB", "StreetB", 2, 20000, 10000);

            Train train = new Train(driver1, 30000, 20000, false, false, port1, port2, 1, new List<IPortable>(), new Dictionary<string, decimal>(), 500, null, 10, 10);
            Plane plane = new Plane(driver2, 10000, 5000, false, false, port2, port1, 2, new List<IPortable>(), new Dictionary<string, decimal>(), 1000, null, null);
            Ship ship = new Ship(driver1, 50000, 30000, false, false, port1, port2, 3, new List<IPortable>(), new Dictionary<string, decimal>(), 800, null);

            IPortable item1 = new Chair("Red", 100m, "Wood", 50m, 40m, 500m, true);
            IPortable item2 = new Chair("Blue", 200m, "Metal", 70m, 60m, 1000m, false);

            Console.WriteLine("Test 1: Train Loading");
            train.LoadCargo(new List<IPortable> { item1, item2 });
            if (train.GetCurrentWeight() == 1500 && train.GetCurrentVolume() == 3000)
            {
                Console.WriteLine("Test 1: Success");
            }
            else
            {
                Console.WriteLine("Test 1: Failed");
            }

            Console.WriteLine("Test 2: Train Approve for Travel");
            train.ApproveForTravel();
            if (train.IsReadyToDrive)
            {
                Console.WriteLine("Test 2: Success");
            }
            else
            {
                Console.WriteLine("Test 2: Failed");
            }

            Console.WriteLine("Test 3: Train Travel");
            train.TravelToNextPort();
            if (train.CurrentPort == port2 && train.NextPort == null)
            {
                Console.WriteLine("Test 3: Success");
            }
            else
            {
                Console.WriteLine("Test 3: Failed");
            }

            Console.WriteLine("Test 4: Train Unloading");
            train.UnloadCargo(new List<IPortable> { item1, item2 });
            if (train.GetCurrentWeight() == 0 && train.GetCurrentVolume() == 0)
            {
                Console.WriteLine("Test 4: Success");
            }
            else
            {
                Console.WriteLine("Test 4: Failed");
            }

            Console.WriteLine("Test 5: Plane Loading");
            plane.LoadCargo(new List<IPortable> { item1, item2 });
            if (plane.StorageRoom.GetCurrentWeight() == 1500 && plane.StorageRoom.GetCurrentVolume() == 3000)
            {
                Console.WriteLine("Test 5: Success");
            }
            else
            {
                Console.WriteLine("Test 5: Failed");
            }

           Console.WriteLine("Test 6: Plane Approve for Travel");
            plane.ApproveForTravel();
            if (plane.IsReadyToDrive)
            {
                Console.WriteLine("Test 6: Success");
            }
            else
            {
                Console.WriteLine("Test 6: Failed");
            }

            Console.WriteLine("Test 7: Plane Travel");
            plane.TravelToNextPort();
            if (plane.CurrentPort == port1 && plane.NextPort == null)
            {
                Console.WriteLine("Test 7: Success");
            }
            else
            {
                Console.WriteLine("Test 7: Failed");
            }

            Console.WriteLine("Test 8: Plane Unloading");
            plane.UnloadCargo(new List<IPortable> { item1, item2 });
            if (plane.StorageRoom.GetCurrentWeight() == 0 && plane.StorageRoom.GetCurrentVolume() == 0)
            {
                Console.WriteLine("Test 8: Success");
            }
            else
            {
                Console.WriteLine("Test 8: Failed");
            }

            Console.WriteLine("Test 9: Ship Loading");
            ship.LoadContainers(new List<IContainable> { plane.StorageRoom });
            if (ship.Containers.Count == 1)
            {
                Console.WriteLine("Test 9: Success");
            }
            else
            {
                Console.WriteLine("Test 9: Failed");
            }
            Console.WriteLine("Test 10: Ship Approve for Travel");
            ship.ApproveForTravel();
            if (ship.IsReadyToDrive)
            {
                Console.WriteLine("Test 10: Success");
            }
            else
            {
                Console.WriteLine("Test 10: Failed");
            }
            Console.WriteLine("Test 11: Ship Travel");
            ship.TravelToNextPort();
            if (ship.CurrentPort == port2 && ship.NextPort == null)
            {
                Console.WriteLine("Test 11: Success");
            }
            else
            {
                Console.WriteLine("Test 11: Failed");
            }
            Console.WriteLine("Test 12: Ship Unloading");
            ship.UnloadContainers();
            if (ship.Containers.Count == 0)
            {
                Console.WriteLine("Test 12: Success");
            }
            else
            {
                Console.WriteLine("Test 12: Failed");
            }
            Console.WriteLine("Test 13: Validate Ship");
            if (ship.GetCurrentWeight() == 0 && ship.GetCurrentVolume() == 0)
            {
                Console.WriteLine("Test 13: Success");
            }
            else
            {
                Console.WriteLine("Test 13: Failed");
            }
            Console.WriteLine("Test 14: Validate Plane");
            if (plane.GetCurrentWeight() == 0 && plane.GetCurrentVolume() == 0)
            {
                Console.WriteLine("Test 14: Success");
            }
            else
            {
                Console.WriteLine("Test 14: Failed");
            }
            Console.WriteLine("Test 15: Validate Train");
            if (train.GetCurrentWeight() == 0 && train.GetCurrentVolume() == 0)
            {
                Console.WriteLine("Test 15: Success");
            }
            else
            {
                Console.WriteLine("Test 15: Failed");
            }
        }
    
    }
}
