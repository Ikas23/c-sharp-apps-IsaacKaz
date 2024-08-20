using System;
using System.Collections.Generic;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class Train : CargoVehicle
    {
        public List<IContainable> Wagons { get; set; }
        public Crone SeatingArrangement { get; set; }

        public Train(Driver driver, decimal maxWeight, decimal maxVolume, bool isReadyToDrive, bool isOverloaded, StorageStructure nextPort, StorageStructure currentPort,
          int travelID, List<IPortable> cargoItems, Dictionary<string, decimal> expectedPayment, int distanceToNextPort, IShippingPriceCalculator priceCalculator,
          int rows, int columns)
           : base(driver, maxWeight, maxVolume, isReadyToDrive, isOverloaded, nextPort, currentPort, travelID, cargoItems, expectedPayment, distanceToNextPort, priceCalculator)
        {
            Wagons = new List<IContainable>();
            SeatingArrangement = new Crone(rows, columns); 
        }
        public void LoadCargo(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (Load(items[i]) == true)
                {
                    Console.WriteLine("Success to load");
                }
                else
                {
                    Console.WriteLine("Failed to load");
                }
            }
        }

        public void TravelToNextPort()
        {
            if (IsReadyToDrive == false)
            {
                Console.WriteLine("Not ready yet");
                return;
            }
            Console.WriteLine("On the way");
            this.CurrentPort = NextPort;
            this.NextPort = null;
            IsReadyToDrive = false;
            Console.WriteLine("Arrived at Destination");
        }

        public void UnloadCargo(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (Unload(items[i]) == true)
                {
                    Console.WriteLine("Unloaded item");
                }
                else
                {
                    Console.WriteLine("Failed to unload item");
                }
            }
        }

        public void UnloadCargo(IPortable item)
        {
            if (Unload(item) == true)
            {
                Console.WriteLine("Unloaded item");
            }
            else
            {
                Console.WriteLine("Failed to unload item");
            }
        }

        public void UnloadCargo()
        {
            if (Unload() == true)
            {
                Console.WriteLine("Unloaded cargo");
            }
            else
            {
                Console.WriteLine("Failed to unload cargo");
            }
        }

        public void GetPricingList()
        {
            if (CargoItems == null || CargoItems.Count == 0)
            {
                Console.WriteLine("Empty nothing to calculate");
                return;
            }

            Console.WriteLine("Pricing List:");
            Console.WriteLine("-----------------------------");

            decimal totalCost = 0;
            for (int i = 0; i < CargoItems.Count; i++)
            {
                var item = CargoItems[i]; 
                decimal itemPrice = PriceCalculator.CalculatePrice(item, DistanceToNextPort);
                Console.WriteLine($"Item: {item.GetType().Name}, Price: {itemPrice:C}");

                totalCost += itemPrice;
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Total Cost for the trip: {totalCost:C}");
        }
    }

    public class Crone
    {
        public readonly int rows, columns;

        public Crone(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }

        public int GetSeats() => rows * columns;
    }
}
