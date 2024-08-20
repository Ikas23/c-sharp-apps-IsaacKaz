using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app.FinalWork
{
    public class TV : ElectricalItem
    {
        public string ScreenType { get; private set; }
        public string Resolution { get; private set; }

        public TV(int width, int length, int height, decimal weight, bool Fragile, string screenType, string resolution): base(width, length, height, weight, Fragile)
        {
            this.ScreenType = screenType;
            this.Resolution = resolution;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"TV Info:\n Screen Type:"+ this.ScreenType +" Resolution: "+this.Resolution+ " Weight: "+ GetWeight() +" Fragile: "+IsFragile());
        }
    }
}
