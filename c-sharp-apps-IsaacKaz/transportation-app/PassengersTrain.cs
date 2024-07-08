using c_sharp_apps_IsaacKaz.transportation_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class PassengersTrain : PublicVehicle
    {
        private Crone crone;
        private int cronesAmount;
        private int currentPassengers;

        public PassengersTrain(int line, int id, int maxSpeed, Crone crone, int cronesAmount) : base(line, id, maxSpeed, crone.rows * crone.columns * cronesAmount)
        {
            this.Crone = crone;
            this.CronesAmount = cronesAmount;
            this.CurrentPassengers = 0;
        }


        public Crone Crone { get => crone; set => crone = value; }
        public int CronesAmount { get => cronesAmount; set => cronesAmount = value; }
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

