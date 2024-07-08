using c_sharp_apps_IsaacKaz.transportation_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.transportation_app
{
    public class PassengersAirplain
    {
        private int line;
        private int id;
        private int enginesNum;
        private int wingLength;
        private int rows;
        private int columns;
        private int currentPassengers;

        public PassengersAirplain(int line, int id, int enginesNum, int wingLength, int rows, int columns)
        {
            this.Line = line;
            this.Id = id;
            this.EnginesNum = enginesNum;
            this.WingLength = wingLength;
            this.Rows = rows;
            this.Columns = columns;
            this.currentPassengers = 0;
        }

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public int EnginesNum { get => enginesNum; set => enginesNum = value; }
        public int WingLength { get => wingLength; set => wingLength = value; }
        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }
        public int Seats => Rows * Columns; 
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public int RejectedPassengers { get; private set; }

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



