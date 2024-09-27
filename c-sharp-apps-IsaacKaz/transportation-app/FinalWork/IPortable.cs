using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public interface IPortable
    {

        decimal GetArea();
        decimal[] GetSize(); 
        decimal GetVolume();
        decimal GetWeight();
        void PackageItem();
        bool IsPackaged();
        void UnPackage();
        bool IsLoaded();
        bool IsFragile();
        StorageStructure GetLocation();
     
         
        

    }
}
