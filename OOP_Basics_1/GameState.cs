using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class GameState
    {
        public void PrintPlayersCount(List<Player> playersList)  
        {
            Display.Print(playersList.Count.ToString());
        }

        public void PrintSumOfPoints(List<Player> playersList) 
        {
            int playersPointsSum = 0;
            foreach (Player p in playersList) 
            {
                playersPointsSum += p.Points;
            }
            Display.Print(playersPointsSum.ToString());
        }
    }
}
