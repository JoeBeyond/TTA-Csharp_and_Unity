using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21BlackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Joe";
            //game += player;
            //game -= player;

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Archduke Sycrab", "General Byronaxis", "Doctor Fyriloth" };
            //game.ListPlayers();
            
            Console.ReadLine();

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);

            Console.ReadLine();
        }
    }
}
