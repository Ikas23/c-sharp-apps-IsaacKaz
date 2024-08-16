using c_sharp_apps_IsaacKaz.transportation_app;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace c_sharp_apps_IsaacKaz.transportation_app;


public class TestWork
{
    public static void Main()
    {
        // Set up the environment
        Driver driver1 = new Driver("John", "Doe", "1234", CargoType.Truck);
        Driver driver2 = new Driver("Jane", "Smith", "5678", CargoType.Plane);

        Port port1 = new Port("Port 1", "CountryA", "CityA", "StreetA", 1, 10000, 5000);
        Port port2 = new Port("Port 2", "CountryB", "CityB", "StreetB", 2, 20000, 10000);

        // Instantiate CargoVehicles with correct parameters
        Train train = new Train(driver1, 30000, 20000, false, false, port1, port2, 1, new List<IPortable>(), new Dictionary<string, decimal>(), 500, null);
        Plane plane = new Plane(driver2, 10000, 5000, false, false, port2, port1, 2, new List<IPortable>(), new Dictionary<string, decimal>(), 1000, null, new Crone(10, 10));
        Ship ship = new Ship(driver1, 50000, 30000, false, false, port1, port2, 3, new List<IPortable>(), new Dictionary<string, decimal>(), 800, null);

        // Create items to test loading and unloading
        IPortable item1 = new Furniture() { Volume = 1000, Weight = 500 };
        IPortable item2 = new Furniture() { Volume = 2000, Weight = 1000 };

        // Test loading items into the train
        Console.WriteLine("Test Train Loading:");
        train.LoadCargo(new List<IPortable> { item1, item2 });
        if (train.GetCurrentWeight() == 1500 && train.GetCurrentVolume() == 3000)
        {
            Console.WriteLine("Train Load Test Passed");
        }
        else
        {
            Console.WriteLine("Train Load Test Failed");
        }

        // Test traveling to next port with the train
        Console.WriteLine("Test Train Travel:");
        train.ApproveForTravel();
        train.TravelToNextPort();
        if (train.CurrentPort == port2 && train.NextPort == null)
        {
            Console.WriteLine("Train Travel Test Passed");
        }
        else
        {
            Console.WriteLine("Train Travel Test Failed");
        }

        // Test unloading items from the train
        Console.WriteLine("Test Train Unloading:");
        train.UnloadCargo(new List<IPortable> { item1, item2 });
        if (train.GetCurrentWeight() == 0 && train.GetCurrentVolume() == 0)
        {
            Console.WriteLine("Train Unload Test Passed");
        }
        else
        {
            Console.WriteLine("Train Unload Test Failed");
        }

        // Test loading items into the plane
        Console.WriteLine("Test Plane Loading:");
        plane.LoadCargo(new List<IPortable> { item1, item2 });
        if (plane.StorageRoom.GetCurrentWeight() == 1500 && plane.StorageRoom.GetCurrentVolume() == 3000)
        {
            Console.WriteLine("Plane Load Test Passed");
        }
        else
        {
            Console.WriteLine("Plane Load Test Failed");
        }

        // Test traveling to next port with the plane
        Console.WriteLine("Test Plane Travel:");
        plane.ApproveForTravel();
        plane.TravelToNextPort();
        if (plane.CurrentPort == port1 && plane.NextPort == null)
        {
            Console.WriteLine("Plane Travel Test Passed");
        }
        else
        {
            Console.WriteLine("Plane Travel Test Failed");
        }

        // Test unloading items from the plane
        Console.WriteLine("Test Plane Unloading:");
        plane.UnloadCargo(new List<IPortable> { item1, item2 });
        if (plane.StorageRoom.GetCurrentWeight() == 0 && plane.StorageRoom.GetCurrentVolume() == 0)
        {
            Console.WriteLine("Plane Unload Test Passed");
        }
        else
        {
            Console.WriteLine("Plane Unload Test Failed");
        }

        // Test loading items into the ship
        Console.WriteLine("Test Ship Loading:");
        ship.LoadContainers(new List<IContainable> { plane.StorageRoom });
        if (ship.Containers.Count == 1)
        {
            Console.WriteLine("Ship Load Test Passed");
        }
        else
        {
            Console.WriteLine("Ship Load Test Failed");
        }

        // Test traveling to next port with the ship
        Console.WriteLine("Test Ship Travel:");
        ship.ApproveForTravel();
        ship.TravelToNextPort();
        if (ship.CurrentPort == port2 && ship.NextPort == null)
        {
            Console.WriteLine("Ship Travel Test Passed");
        }
        else
        {
            Console.WriteLine("Ship Travel Test Failed");
        }

        // Test unloading containers from the ship
        Console.WriteLine("Test Ship Unloading:");
        ship.UnloadContainers();
        if (ship.Containers.Count == 0)
        {
            Console.WriteLine("Ship Unload Test Passed");
        }
        else
        {
            Console.WriteLine("Ship Unload Test Failed");
        }
    }