using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class PublicVehicle
    {
        private int line;
        private int id;
        public int maxSpeed;
        private int seats;

        public PublicVehicle(int line, int id, int maxSpeed, int seats)
        {
            this.line = line;
            this.id = id;
            this.MaxSpeed = maxSpeed;
            this.seats = seats;
        }

        public PublicVehicle(int line, int id)
        {
            this.line = line;
            this.id = id;
            this.MaxSpeed = 40;
            this.seats = 0;
        }

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public virtual int MaxSpeed
        {
            get => maxSpeed;
            set => maxSpeed = value > 40 ? 40 : value;
        }
        public int Seats { get => seats; set => seats = value; }

        public virtual void UploadPassengers(int passengers) { }
        public virtual bool CalculateHasRoom() => true;
        public virtual bool HasRoom => CalculateHasRoom();
    }


}


