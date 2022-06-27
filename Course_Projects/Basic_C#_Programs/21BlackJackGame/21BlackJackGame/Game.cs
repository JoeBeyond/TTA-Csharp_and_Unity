using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21BlackJackGame
{
    public abstract class Game
    {
        // <p10> [vrsn]0.90 :
        private List<Player> _players = new List<Player>();

        // <p10> [vrsn]0.90 :
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        // <p10> [vrsn]0.90 :
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }

        // <p3> [vrsn]0.90 : // <p10> [vrsn]0.90 :
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play();
        
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
