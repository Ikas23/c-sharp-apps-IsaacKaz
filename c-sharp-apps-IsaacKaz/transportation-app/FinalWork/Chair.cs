using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class Chair : Furniture
    {
        public decimal weight { get; set; }
        public bool fragile { get; set; }
        public bool loaded { get; set; }
        public bool packaged { get; set; }
        public StorageStructure location { get; set; }

        public Chair(string color, decimal width, string material, decimal length, decimal height, decimal weight, bool fragile)
            : base(color, width, material, length, height)
        {
            this.weight = weight;
            this.fragile = fragile;
            this.loaded = false;
            this.packaged = false;
            this.location = null;
        }
        public override decimal GetWeight()
        {
            return this.weight;
        }
        public override bool IsFragile()
        {
            if (this.fragile == true)
            {
                return true;
            }
            return false;
        }
        
        public override bool IsPackaged()
        {
            if (this.packaged == true)
            {
                return true;
            }
            return false;
        }
        public override bool IsLoaded()
        {
            return this.loaded;
        }

        public override StorageStructure GetLocation()
        {
            return this.location;
        }

        public override void PackageItem()
        {
            this.packaged = true;
            Console.WriteLine("The chair has been packaged.");
        }

        public override void UnPackage()
        {
            this.packaged = false;
            Console.WriteLine("The chair has been unpackaged.");
        }

        public void SetLocation(StorageStructure location)
        {
            this.location = location;
        }

        public void SetLoaded(bool loaded)
        {
            this.loaded = loaded;
        }

    }
}
