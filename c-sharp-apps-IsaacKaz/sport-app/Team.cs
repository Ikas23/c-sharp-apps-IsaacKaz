using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.sport_app
{
    public class Team
    {
        private string name { get; set; }
        private string city { get; set; }
        private string League { get; set; }
        private int total_game { get; set; }
        private int played_game { get; set; }
        private int win { get; set; }
        private int lose { get; set; }
        private int teiko { get; set; }
        private int point { get; set; }
        private int goalsFor { get; set; }
        private int goalsaGainst { get; set; }
        private int goalsDiferrencial { get; set; }

        public string GetName()
        {
            return this.name;
        }
        public int Getpoint()
        {
            return this.point;
        }
        public string Getcity()
        {
            return this.city;
        }
        public Team(string name, string city)
        {
            this.name = name;
            this.city = city;
           
        }
    }
}
