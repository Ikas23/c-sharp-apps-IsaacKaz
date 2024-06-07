using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.sport_app
{
    public class Game
    {

        private Team TeamA {  get; set; }
        private Team TeamB { get; set; }
        private int numOfGoals_A { get; set; }
        private int numOfGoals_B { get; set; }
        private int currentMinute { get; set; }
        private bool currentGame { get; set; }

        private Game(Team TeamA, Team TeamB, int numOfGoals_A, int numOfGoals_B, int currentMinute, bool currentGame)
        {
            this.TeamA = TeamA;
            this.TeamB = TeamB;
            this.numOfGoals_A = numOfGoals_A;
            this.numOfGoals_B = numOfGoals_B;
            this.currentMinute = currentMinute;
            this.currentGame = currentGame;
        }   
    }

}
