using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public enum CargoType
    {
        Plane,
        Train,
        Ship,
        Car,
        Motorcycle,
        Truck
    }
    public abstract class CargoVehicle : IContainable
    {
        public CargoVehicle(Driver driver, decimal maxWeight, decimal maxVolume, bool isReadyToDrive, bool isOverloaded, StorageStructure nextPort, StorageStructure currentPort,
            int travelID, List<IPortable> cargoItems, Dictionary<string, decimal> expectedPayment, int distanceToNextPort, IShippingPriceCalculator priceCalculator)
        {
            Driver = driver;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
            IsReadyToDrive = isReadyToDrive;
            IsOverloaded = isOverloaded;
            NextPort = nextPort;
            CurrentPort = currentPort;
            TravelID = travelID;
            CargoItems = cargoItems;
            ExpectedPayment = expectedPayment;
            DistanceToNextPort = distanceToNextPort;
            PriceCalculator = priceCalculator;
        }

        public Driver Driver { get; set; }
        public decimal MaxWeight { get; set; }
        public decimal MaxVolume { get; set; }
        public bool IsReadyToDrive { get; set; }
        public bool IsOverloaded { get; set; }
        public StorageStructure NextPort { get; set; }
        public StorageStructure CurrentPort { get; set; }
        public int TravelID { get; set; }
        public List<IPortable> CargoItems { get; set; }
        public Dictionary<string, decimal> ExpectedPayment { get; set; }
        public int DistanceToNextPort { get; set; }
        public IShippingPriceCalculator PriceCalculator { get; set; }


        public decimal GetMaxVolume() { return MaxVolume; }
        public decimal GetMaxWeight() { return MaxWeight; }

        public bool Load(IPortable item)
        {
            if (IsOverload(item.GetWeight(), item.GetVolume()) == true)
            {
                return false;
            }
            CargoItems.Add(item);
            return true;
        }

        public bool Load(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (Unload(items[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

        public bool Unload(IPortable item)
        {
            return CargoItems.Remove(item);
        }

        public bool Unload(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (Unload(items[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

        public bool Unload()
        {
            CargoItems.Clear();
            return true;
        }

        public bool HasRoom()
        {
            bool hasEnoughVolume = GetCurrentVolume() < MaxVolume;
            bool hasEnoughWeight = GetCurrentWeight() < MaxWeight;

            return hasEnoughVolume && hasEnoughWeight;
        }

        public bool Overload()
        {
            bool exceedsMaxWeight = GetCurrentWeight() > MaxWeight;
            bool exceedsMaxVolume = GetCurrentVolume() > MaxVolume;

            return exceedsMaxWeight || exceedsMaxVolume;
        }

        public bool IsOverload(decimal weight, decimal volume)
        {
            bool willExceedMaxWeight = (GetCurrentWeight() + weight) > MaxWeight;
            bool willExceedMaxVolume = (GetCurrentVolume() + weight) > MaxVolume;

            return willExceedMaxWeight || willExceedMaxVolume;
        }

        public decimal GetCurrentVolume()
        {
            decimal currentVolume = 0;
            for (int i = 0; i < CargoItems.Count; i++)
            {
                currentVolume += CargoItems[i].GetVolume();
            }
            return currentVolume;
        }

        public decimal GetCurrentWeight()
        {
            decimal currentWeight = 0;
            for (int i = 0; i < CargoItems.Count; i++)
            {
                currentWeight += CargoItems[i].GetWeight();
            }
            return currentWeight;
        }

        public void LoadCargo(List<IPortable> itemsToLoad)
        {
            for (int i = 0; i < itemsToLoad.Count; i++)
            {
                Load(itemsToLoad[i]);
            }
            Console.WriteLine("succesful loaded");
        }

        public void ApproveForTravel()
        { IsReadyToDrive = true;
            Console.WriteLine("Ready to go...");
        }

        public void CalculateFinalPrice()
        {
            for (int i = 0; i < CargoItems.Count; i++)
            {
                decimal itemPrice = PriceCalculator.CalculatePrice(CargoItems[i], DistanceToNextPort);
                ExpectedPayment[CargoItems[i].GetType().Name] = itemPrice;
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
            CurrentPort = NextPort;
            NextPort = null;

            IsReadyToDrive = false;
            Console.WriteLine("Arrived at Destination.");
        }
        public virtual string GetPricingList()
        {
            decimal price = 0;  
            for (int i = 0; i < CargoItems.Count; i++)
            { 
            }
        }


    }
}


