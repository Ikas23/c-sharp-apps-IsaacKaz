using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class Plane : CargoVehicle
    {
        public IContainable StorageRoom { get; set; }

        public Plane(Driver driver, decimal maxWeight, decimal maxVolume, bool isReadyToDrive, bool isOverloaded,
            StorageStructure nextPort, StorageStructure currentPort, int travelID, List<IPortable> cargoItems,
            Dictionary<string, decimal> expectedPayment, int distanceToNextPort, IShippingPriceCalculator priceCalculator,
            IContainable storageRoom)
            : base(driver, maxWeight, maxVolume, isReadyToDrive, isOverloaded, nextPort, currentPort, travelID, cargoItems, expectedPayment, distanceToNextPort, priceCalculator)
        {
            StorageRoom = storageRoom;
        }
        public void LoadCargo(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (StorageRoom.GetCurrentWeight() >= items[i].GetWeight() && StorageRoom.GetCurrentVolume() >= items[i].GetVolume())
                {
                    StorageRoom.Load(items[i]);
                    Console.WriteLine("Loaded in the plane");
                }
                else
                {
                    Console.WriteLine("can't load ");
                }
            }
        }
        public void UnloadCargo(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                StorageRoom.Unload(items[i]);
                Console.WriteLine("Unloaded from the plane");
            }
        }
        public void UnloadCargo(IPortable item)
        {
            StorageRoom.Unload(item);
            Console.WriteLine("Unloaded from the plane");
        }
        public void UnloadCargo()
        {
           List<IPortable> allItems = new List<IPortable>(); 
            for (int i = 0; i < allItems.Count; i++)
            {
                StorageRoom.Unload(allItems[i]);
                Console.WriteLine("Unloaded from the plane");
            }
        }
    }
}
