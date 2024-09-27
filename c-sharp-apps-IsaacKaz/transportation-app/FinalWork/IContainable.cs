using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public interface IContainable
    {

        bool Load(IPortable item);
        bool Load(List<IPortable> items);
        bool Unload(IPortable item);
        bool Unload(List<IPortable> items);
        bool Unload();
        bool HasRoom();
        bool Overload();
        decimal GetMaxVolume();
        decimal GetMaxWeight();
        decimal GetCurrentVolume();
        decimal GetCurrentWeight();
    }
}
