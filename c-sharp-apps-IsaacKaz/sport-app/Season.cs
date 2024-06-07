using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.sport_app
{
    public class Season
    {
        private int Year { get; set; }
        private string Type { get; set; }
        private string League { get; set; }
        private int rounds_amount { get; set; }
        private Round NextRound { get; set; }
        private Team[] team { get; set; }
        private int NumOfGroup { get; set; }
        private bool Active { get; set; }

        public Season(int year, string SportType, string league, Team[] team)
        {
            this.Year = year;
            this.Type = Type;
            this.League = league;
            this.team = team;
        }

        



        public void DisplayTable()
        {

            for (int i = 0; i < team.Length; i++)
            {
                Console.WriteLine($"{i} - {team[i].GetName()} - {team[i].Getpoint()}");
            }

        }


    }
}
