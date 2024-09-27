using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class ShippingPriceCalculator : IShippingPriceCalculator
    {
        public decimal ratePerKilometer;
        public ShippingPriceCalculator(CargoType cargoType)
        {
            ratePerKilometer = GetRatePerKilometer(cargoType);
        }
        public decimal GetRatePerKilometer(CargoType cargoType)
        {
            if (cargoType == CargoType.Plane)
            {
                return 50;
            }
            if (cargoType == CargoType.Ship)
            {
                return 20;
            }
            else if (cargoType == CargoType.Train)
            {
                return 5;
            }
            Console.WriteLine("error");
            return 0;
        }
      
        public decimal CalculatePrice(List<IPortable> items, int travelDistance)
        {
            decimal totalUnits = 0;
            for (int i = 0; i < items.Count; i++)
            {
                totalUnits += CalculateUnits(items[i]);
            }
            decimal price = totalUnits * travelDistance * ratePerKilometer;
            return price;
        }
        public decimal CalculatePrice(IPortable item, int travelDistance)
        {
            decimal unit = CalculateUnits(item);
            return unit * travelDistance * ratePerKilometer;
        }
        public decimal CalculateUnits(IPortable item)
        {
            decimal units = (item.GetVolume() /100) + item.GetWeight();

            if (item.IsFragile() == true)
            {
                units = units * 2;
            }
            return units;
        }
    }
}