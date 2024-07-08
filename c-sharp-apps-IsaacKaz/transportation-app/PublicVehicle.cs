using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class PublicVehicle
    {
        
            public int line;
            public int id;
            public int maxSpeed;
            public int seats;

            public PublicVehicle(int line, int id, int maxSpeed, int seats)
            {
                this.line = line;
                this.id = id;
                this.maxSpeed = maxSpeed;
                this.seats = seats;
            }

            public int Line { get => line; set => line = value; }
            public int Id { get => id; set => id = value; }
            public int Seats { get => seats; set => seats = value; }
            public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
    }

    
}
