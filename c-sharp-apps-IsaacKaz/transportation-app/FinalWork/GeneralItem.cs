using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class GeneralItem : IPortable
    {
        private decimal[] size;
        private decimal volume;
        private decimal weight;
        private bool isPackaged;
        private bool isFragile;
        private StorageStructure location;
        private bool isLoaded;

        public GeneralItem(int width, int length, int height, decimal weight, bool isFragile)
        {
            this.size = new decimal[] { width, length, height };
            this.volume = width * length * height;
            this.weight = weight;
            this.isPackaged = false;
            this.isFragile = isFragile;
            this.location = null;
            this.isLoaded = false;
        }
        public decimal GetArea()
        {
            return size[0] * size[1]; 
        }

        public decimal[] GetSize()
        {
            return size;
        }

        public decimal GetVolume()
        {
            return volume;
        }

        public decimal GetWeight()
        {
            return weight;
        }

        public void PackageItem()
        {
            isPackaged = true;
        }

        public bool IsPackaged()
        {
            return isPackaged;
        }

        public void UnPackage()
        {
            isPackaged = false;
        }

        public bool IsFragile()
        {
            return isFragile;
        }

        public StorageStructure GetLocation()
        {
            return location;
        }

        public bool IsLoaded()
        {
            return isLoaded;
        }
    }
}
