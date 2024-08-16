using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public abstract class Furniture : IPortable
    {
        protected Furniture(string color, decimal width, string material, decimal length, decimal height)
        {
            this.Color = color;
            this.Width = width;
            this.Material = material;
            this.Length = length;
            this.Height = height;
        }
        public string Color { get; set; }
        public decimal Width { get; set; }
        public string Material { get; set; }
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public decimal GetVolume()
        {
            return this.Width * this.Length * this.Height;
        }
        public decimal GetArea()
        {
            return this.Width * this.Length;
        }
        public decimal[] GetSize()
        {
            Console.WriteLine("Width; " + Width);
            Console.WriteLine("Length; " + Length);
            Console.WriteLine("Height; "+ Height);
            return [];
        }
        public abstract decimal GetWeight();
        public abstract bool IsFragile();
        public abstract StorageStructure GetLocation();
        public abstract bool IsLoaded();
        public abstract bool IsPackaged();
        public abstract void PackageItem();
        public abstract void UnPackage();
    }
}
