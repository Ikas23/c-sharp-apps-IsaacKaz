using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class ElectricalItem : IPortable
    {

        private decimal[] size;
        private decimal volume;
        private decimal weight;
        private bool Packaged;
        private bool Fragile;
        private StorageStructure location;
        private bool isLoaded;


        public ElectricalItem(int width, int length, int height, decimal weight, bool Fragile)
        {
            this.size = new decimal[] { width, length, height };
            this.volume = width * length * height;
            this.weight = weight;
            this.Packaged = false;
            this.Fragile = Fragile;
            this.location = null;
            isLoaded = false;
        }
        public decimal GetArea()
        {
            return size[1] * size[1];
        }
        public decimal[] GetSize()
        {
            return this.size;
        }
        public decimal GetVolume()
        {
            return this.volume;
        }
        public decimal GetWeight()
        {
            return this.weight;
        }
        public void PackageItem()
        {
            this.Packaged = true;
        }
        public bool IsPackaged()
        {
            if (this.Packaged == true)
            { return true; }
            return false;
        }
        public void UnPackage()
        {
            this.Packaged = false;
            Console.WriteLine("has been unpacked");
        }
        public bool IsFragile()
        {
            if (this.Fragile == true)
            { return true; }
            return false;
        }
        public StorageStructure GetLocation()
        {
            return this.location;
        }
        public bool IsLoaded()
        {
            if (this.isLoaded == true)
            { return true; }
            return false;
        }
    }
}