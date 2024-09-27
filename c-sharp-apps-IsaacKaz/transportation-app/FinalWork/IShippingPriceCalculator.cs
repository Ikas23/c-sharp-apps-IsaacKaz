using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public interface IShippingPriceCalculator
    {
        decimal CalculatePrice(IPortable item, int travelDistance);
        decimal CalculatePrice(List<IPortable> items, int travelDistance);
    }
}
