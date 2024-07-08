using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class Bus
    {
        private int line;
        private int id;
        public int maxSpeed;
        private int seats;
        private int doors;
        private int currentPassengers;

        public Bus(int line, int id, int maxSpeed, int seats, int doors)
        {
            this.Line = line;
            this.Id = id;
            this.MaxSpeed = maxSpeed;
            this.Seats = seats;
            this.Doors = doors;
            this.currentPassengers = 0;
        }

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public int Seats { get => seats; set => seats = value; }
        public int Doors { get => doors; set => doors = value; }
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public int RejectedPassengers { get; private set; }
        public bool HasRoom => currentPassengers < Seats;

        public void UploadPassengers(int passengers)
        {
            if (currentPassengers + passengers <= Seats)
            {
                currentPassengers += passengers;
            }
            else
            {
                RejectedPassengers = (currentPassengers + passengers) - Seats;
                currentPassengers = Seats;
            }
        }
    }


}
