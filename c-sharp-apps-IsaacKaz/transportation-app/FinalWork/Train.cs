using c_sharp_apps_IsaacKaz.transportation_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class Train : CargoVehicle
    {
        public List<IContainable> Wagons { get; set; }
        public Train(Driver driver, decimal maxWeight, decimal maxVolume, bool isReadyToDrive, bool isOverloaded, StorageStructure nextPort, StorageStructure currentPort,
          int travelID, List<IPortable> cargoItems, Dictionary<string, decimal> expectedPayment, int distanceToNextPort, IShippingPriceCalculator priceCalculator)
      : base(driver, maxWeight, maxVolume, isReadyToDrive, isOverloaded, nextPort, currentPort, travelID, cargoItems, expectedPayment, distanceToNextPort, priceCalculator)
        {
            Wagons = new List<IContainable>();
        }
        public void LoadCargo(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (Load(items[i]) == true)
                {
                    Console.WriteLine("succses to load");
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
        private void GetPricingList()
        { }


    }

}
