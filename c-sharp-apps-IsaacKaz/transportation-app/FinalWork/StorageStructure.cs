using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public abstract class StorageStructure : IContainable
    {


        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public decimal MaxVolume { get; set; }
        public decimal MaxWeight { get; set; }
        public decimal currentVolume { get; set; }
        public List<IPortable> StoredItems { get; set; }

        public decimal currentWeight { get; set; }

        protected StorageStructure(string country, string city, string street, int number, decimal maxVolume,
            decimal maxWeight, decimal currentVolume, decimal currentWeight, List<IPortable> storedItems)
        {
            Country = country;
            City = city;
            Street = street;
            Number = number;
            MaxVolume = maxVolume;
            MaxWeight = maxWeight;
            this.currentVolume = currentVolume;
            this.currentWeight = currentWeight;
            StoredItems = storedItems;
        }




        public virtual bool Load(IPortable item)
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

        public bool Load(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (Load(items[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        public virtual bool Unload(IPortable item)
        {
            if (StoredItems.Remove(item))
            {
                currentVolume -= item.GetVolume();
                currentWeight -= item.GetWeight();
                return true;
            }
            return false;
        }
        public bool Unload(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (Load(items[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

        public bool Unload()
        {
            StoredItems.Clear();
            currentVolume = 0;
            currentWeight = 0;
            return true;
        }

        public bool HasRoom()
        {
            bool hasVolumeRoom = currentVolume < MaxVolume;
            bool hasWeightRoom = currentWeight < MaxWeight;

            return hasVolumeRoom && hasWeightRoom;
        }

        public bool Overload()
        {
            bool isOverVolume = currentVolume > MaxVolume;
            bool isOverWeight = currentWeight > MaxWeight;

            return isOverVolume || isOverWeight;
        }

        public virtual bool HasRoom(IPortable item)
        {
            decimal newVolume = currentVolume + item.GetVolume();
            decimal newWeight = currentWeight + item.GetWeight();

            if (newVolume <= MaxVolume && newWeight <= MaxWeight)
            {
                return true; 
            }
            return false;
        }

        public decimal GetMaxVolume() { return MaxVolume; }

        public decimal GetMaxWeight() { return MaxWeight; }

        public decimal GetCurrentVolume() { return currentVolume; }

        public decimal GetCurrentWeight() {  return currentWeight; }

        public decimal CalculateCurrentVolume()
        {
            decimal totalVolume = 0;
            for (int i = 0; i < StoredItems.Count; i++)
            {
                totalVolume += StoredItems[i].GetVolume();
            }
            return totalVolume;
        }

        public decimal CalculateCurrentWeight()
        {
            decimal totalWeight = 0;
            for (int i = 0; i < StoredItems.Count; i++)
            {
                totalWeight += StoredItems[i].GetWeight();
            }
            return totalWeight;
        }
    }


}
 
