using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21BlackJackGame
{
    public class Player
    {
        // <p1> [vrsn]0.90 : Create a Public constructor of [Player] that takes two parameters. Player Object is
        // defined by 3 Properties, 2 of which in turn have their own values.
        public Player(string name, int beginningBalance)
        {
            //  <p1> [vrsn]0.90 : Object-Property [Hand] is created in a new empty List with the IR (inference/reference) of List
            //  attributes of data-type [Card].
            Hand = new List<Card>();

            // <p1> [vrsn]0.90 : Object-Property [Balance] is assigned the value of Parameter/Variable [beginningBalance].
            Balance = beginningBalance;

            // <p1> [vrsn]0.90 : Object-Property [Name] is assigned the value of Parameter/Variable [name].
            Name = name;
        }

        // <p10> [vrsn]0.90 :
        private List<Card> _hand = new List<Card>();

        // <p10> [vrsn]0.90 :
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }

        // <p2> [vrsn]0.90 :
        public bool Stay { get; set; }

        // <p3> [vrsn]0.90 :
        public bool Bet(int amount)
        {
            // <p3> [vrsn]0.90 :
            if (Balance - amount < 0)
            {
                // <p3> [vrsn]0.90 :
                Console.WriteLine("You don't have enough to place a bet that size.");

                // <p3> [vrsn]0.90 :
                return false;
            }

            // <p3> [vrsn]0.90 :
            else
            {
                // <p3> [vrsn]0.90 :
                Balance -= amount;

                // <p3> [vrsn]0.90 :
                return true;
            }
        }

        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
