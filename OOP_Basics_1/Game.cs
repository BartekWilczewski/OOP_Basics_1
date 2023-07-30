using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Game
    {
        public string GameName { get; set; }
        public List<Player> PlayerList { get; set; }

        public GameState GameState { get; set; }
        public void PrintGameName()
        {
            Display.Print(GameName);
        }
    }
}
