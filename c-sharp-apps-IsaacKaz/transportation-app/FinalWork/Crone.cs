using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class Crone 
    {
        public readonly int rows, columns;

        public Crone(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
        public int GetSeats() => rows * columns;

    }
}
