using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class Ship : CargoVehicle
    {
        public List<IContainable> Containers { get; set; }
   
            public Ship(Driver driver, decimal maxWeight, decimal maxVolume, bool isReadyToDrive, bool isOverloaded,
                StorageStructure nextPort, StorageStructure currentPort, int travelID, List<IPortable> cargoItems,
                Dictionary<string, decimal> expectedPayment, int distanceToNextPort, IShippingPriceCalculator priceCalculator)
                : base(driver, maxWeight, maxVolume, isReadyToDrive, isOverloaded, nextPort, currentPort, travelID, cargoItems, expectedPayment, distanceToNextPort, priceCalculator)
            {
                Containers = new List<IContainable>();
            }
            public void LoadContainers(List<IContainable> containers)
            {
                for (int i = 0; i < containers.Count; i++)
                {
                    Containers.Add(containers[i]);
                }
                Console.WriteLine("loaded");
            }
            public void TravelToNextPort()
            {
                if (IsReadyToDrive == false)
                {
                    Console.WriteLine("Ship is not ready to travel.");
                    return;
                }

                CurrentPort = NextPort;
                NextPort = null;
                IsReadyToDrive = false;
                Console.WriteLine("Ship arrived");
            }
        public void UnloadContainers()
        {
            Containers.Clear();
            Console.WriteLine("empty ship");
        }
    }
    

}
