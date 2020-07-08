using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<player, int> Bets { get; set; }

        public abstract void Play();
        public  virtual void ListPlayers()
        {
            foreach (player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
