using c_sharp_apps_IsaacKaz.transportation_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{

    public class PassengersAirplain : PublicVehicle
    {
        private int enginesNum;
        private int wingLength;
        private int rows;
        private int columns;
        private int currentPassengers;

        public PassengersAirplain(int line, int id, int enginesNum, int wingLength, int rows, int columns)
            : base(line, id, 1000, rows * columns - 7)
        {
            this.EnginesNum = enginesNum;
            this.WingLength = wingLength;
            this.Rows = rows;
            this.Columns = columns;
            this.currentPassengers = 0;
        }

        public int EnginesNum { get => enginesNum; set => enginesNum = value; }
        public int WingLength { get => wingLength; set => wingLength = value; }
        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }
        public int Seats => Rows * Columns - 7;
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public int RejectedPassengers { get; private set; }

        public override int MaxSpeed
        {
            get => base.MaxSpeed;
            set => base.MaxSpeed = value > 1000 ? 1000 : value;
        }

        public override bool CalculateHasRoom() => CurrentPassengers < Seats;

        public override void UploadPassengers(int passengers)
        {
            if (CurrentPassengers + passengers <= Seats)
            {
                CurrentPassengers += passengers;
            }
            else
            {
                RejectedPassengers = (CurrentPassengers + passengers) - Seats;
                CurrentPassengers = Seats;
            }
        }

        }

}





