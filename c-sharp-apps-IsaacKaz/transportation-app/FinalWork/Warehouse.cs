using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{ 
    public class Warehouse: StorageStructure
    {
        public Warehouse(string country, string city, string street, int number, decimal maxVolume, decimal maxWeight)
            : base(country, city, street, number, maxVolume, maxWeight, 0, 0, new List<IPortable>())
        { 
        
        }
      
        public override bool Load(IPortable item)
        {
            if (HasRoom(item) == true)
            {
                StoredItems.Add(item);
                currentVolume += item.GetVolume();
                currentWeight += item.GetWeight();
                return true;
            }
            return false;
        }

        public override bool Unload(IPortable item)
        {
            if (StoredItems.Remove(item) == true)
            {
                currentVolume -= item.GetVolume();
                currentWeight -= item.GetWeight();
                return true;
            }
            return false;
        }
    }
}
