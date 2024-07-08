using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class Bus : PublicVehicle
    {
        private int doors;
        private int currentPassengers;

        public Bus(int line, int id, int maxSpeed, int seats, int doors)
            : base(line, id, maxSpeed, seats)
        {
            this.Doors = doors;
            this.currentPassengers = 0;
        }

        public int Doors { get => doors; set => doors = value; }
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public int RejectedPassengers { get; private set; }

        public override int MaxSpeed
        {
            get => base.MaxSpeed;
            set => base.MaxSpeed = value > 120 ? 120 : value;
        }

        public override bool CalculateHasRoom() => CurrentPassengers < Seats * 1.1;

        public override void UploadPassengers(int passengers)
        {
            int maxPassengers = (int)Math.Ceiling(Seats * 1.1);
            if (CurrentPassengers + passengers <= maxPassengers)
            {
                CurrentPassengers += passengers;
            }
            else
            {
                RejectedPassengers = (CurrentPassengers + passengers) - maxPassengers;
                CurrentPassengers = maxPassengers;
            }
        }

      }



}
