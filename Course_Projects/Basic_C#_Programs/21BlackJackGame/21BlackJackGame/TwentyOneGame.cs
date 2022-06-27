using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21BlackJackGame
{
    public class TwentyOneGame : Game, IWalkAway
    {
        // <p2> [vrsn]0.90 :
        public TwentyOneDealer Dealer { get; set; }

        // <p2> [vrsn]0.90 :
        public override void Play()
        {
            // <p2> [vrsn]0.90 :
            Dealer = new TwentyOneDealer();

            // <p2> [vrsn]0.90 :
            foreach (Player player in Players)
            {
                // <p3> [vrsn]0.90 :
                player.Hand = new List<Card>();

                // <p3> [vrsn]0.90 :
                player.Stay = false;
            }

            // <p3> [vrsn]0.90 :
            Dealer.Hand = new List<Card>();

            // <p3> [vrsn]0.90 :
            Dealer.Stay = false;

            // <p3> [vrsn]0.90 :
            Dealer.Deck = new Deck();

            // <p10> [vrsn]0.90 :
            Dealer.Deck.Shuffle();

            // <p3> [vrsn]0.90 :
            Console.WriteLine("Place your bet!");

            // <p3> [vrsn]0.90 :
            foreach (Player player in Players)
            {
                // <p3> [vrsn]0.90 :
                int bet = Convert.ToInt32(Console.ReadLine());

                // <p3> [vrsn]0.90 :
                bool successfullyBet = player.Bet(bet);

                // <p3> [vrsn]0.90 :
                if (!successfullyBet)
                {
                    // <p3> [vrsn]0.90 :
                    return;
                }

                // <p3> [vrsn]0.90 :
                Bets[player] = bet;
            }

            // <p4> [vrsn]0.90 :
            for (int i = 0; i < 2; i++)
            {
                // <p4> [vrsn]0.90 :
                Console.WriteLine("Dealing...");

                // <p4> [vrsn]0.90 :
                foreach (Player player in Players)
                {
                    // <p4> [vrsn]0.90 :
                    Console.Write("{0}",player.Name);

                    // <p4> [vrsn]0.90 :
                    Dealer.Deal(player.Hand);

                    // <p4> [vrsn]0.90 :
                    if (i == 1)
                    {

                        // <p6> [vrsn]0.90 :
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);

                        // <p6> [vrsn]0.90 :
                        if (blackJack)
                        {

                            // <p6> [vrsn]0.90 :
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);

                            // <p6> [vrsn]0.90 :
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);

                            // <p6> [vrsn]0.90 :
                            return;
                        }
                    }
                }

                // <p6> [vrsn]0.90 :
                Console.WriteLine("Dealer: ");

                // <p6> [vrsn]0.90 :
                Dealer.Deal(Dealer.Hand);

                // <p6> [vrsn]0.90 :
                if (i == 1)
                {

                    // <p6> [vrsn]0.90 :
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);

                    // <p6> [vrsn]0.90 :
                    if (blackJack)
                    {

                        // <p6> [vrsn]0.90 :
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");

                        // <p6> [vrsn]0.90 :
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {

                            // <p6> [vrsn]0.90 :
                            Dealer.Balance += entry.Value;
                        }

                        // <p10> [vrsn]0.90 :
                        return;
                    }
                }
            }

            // <p7> [vrsn]0.90 :
            foreach (Player player in Players)
            {

                // <p7> [vrsn]0.90 :
                while (!player.Stay)
                {

                    // <p7> [vrsn]0.90 :
                    Console.WriteLine("Your cards are: ");

                    // <p7> [vrsn]0.90 :
                    foreach (Card card in player.Hand)
                    {

                        // <p7> [vrsn]0.90 :
                        Console.Write("{0} ", card.ToString());
                    }

                    // <p7> [vrsn]0.90 :
                    Console.WriteLine("\n\nHit or Stay?");

                    // <p7> [vrsn]0.90 :
                    string answer = Console.ReadLine().ToLower();

                    // <p7> [vrsn]0.90 :
                    if (answer == "stay")
                    {
                        // <p7> [vrsn]0.90 :
                        player.Stay = true;

                        // <p7> [vrsn]0.90 :
                        break;
                    }

                    // <p7> [vrsn]0.90 :
                    else if (answer == "hit")
                    {
                        // <p7> [vrsn]0.90 :
                        Dealer.Deal(player.Hand);
                    }

                    // <p7> [vrsn]0.90 :
                    bool busted = TwentyOneRules.IsBusted(player.Hand);

                    // <p7> [vrsn]0.90 :
                    if (busted)
                    {
                        // <p7> [vrsn]0.90 :
                        Dealer.Balance += Bets[player];

                        // <p7> [vrsn]0.90 :
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);

                        // <p7> [vrsn]0.90 :
                        Console.WriteLine("Do you want to play again?");

                        // <p7> [vrsn]0.90 :
                        answer = Console.ReadLine().ToLower();

                        // <p7> [vrsn]0.90 :
                        if (answer == "yes" || answer == "yeah")
                        {
                            // <p7> [vrsn]0.90 :
                            player.IsActivelyPlaying = true;

                            // <p10> [vrsn]0.90 :
                            return;
                        }

                        // <p7> [vrsn]0.90 :
                        else
                        {
                            // <p7> [vrsn]0.90 :
                            player.IsActivelyPlaying = false;

                            // <p10> [vrsn]0.90 :
                            return;
                        }
                    }
                }
            }

            // <p7> [vrsn]0.90 :
            Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);

            // <p8> [vrsn]0.90 :
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            // <p8> [vrsn]0.90 :
            while (!Dealer.Stay && !Dealer.IsBusted)
            {
                // <p8> [vrsn]0.90 :
                Console.WriteLine("Dealer is hitting...");

                // <p8> [vrsn]0.90 :
                Dealer.Deal(Dealer.Hand);

                // <p8> [vrsn]0.90 :
                Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);

                // <p8> [vrsn]0.90 :
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }

            // <p8> [vrsn]0.90 :
            if (Dealer.Stay)
            {
                // <p8> [vrsn]0.90 :
                Console.WriteLine("Dealer is staying.");
            }

            // <p8> [vrsn]0.90 :
            if (Dealer.IsBusted)
            {
                // <p8> [vrsn]0.90 :
                Console.WriteLine("Dealer busted!");

                // <p8> [vrsn]0.90 :
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    // <p8> [vrsn]0.90 :
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);

                    // <p8> [vrsn]0.90 :
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);

                    // <p8> [vrsn]0.90 :
                    Dealer.Balance -= entry.Value;
                }

                // <p8> [vrsn]0.90 :
                return;
            }



            // <p8> [vrsn]0.90 :
            foreach (Player player in Players)
            {
                // <p8> [vrsn]0.90 :
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);

                // <p9> [vrsn]0.90 :
                if (playerWon == null)
                {
                    // <p9> [vrsn]0.90 :
                    Console.WriteLine("Push! No one wins.");

                    // <p9> [vrsn]0.90 :
                    player.Balance += Bets[player];

                }

                // <p9> [vrsn]0.90 :
                else if (playerWon == true)
                {
                    // <p9> [vrsn]0.90 :
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);

                    // <p9> [vrsn]0.90 :
                    player.Balance += (Bets[player] * 2);

                    // <p9> [vrsn]0.90 :
                    Dealer.Balance -= Bets[player];
                }

                // <p9> [vrsn]0.90 :
                else
                {
                    // <p9> [vrsn]0.90 :
                    Console.WriteLine("Dealer wins {0}", Bets[player]);

                    // <p9> [vrsn]0.90 :
                    Dealer.Balance += Bets[player];
                }

                // <p9> [vrsn]0.90 :
                Console.WriteLine("Play again?");

                // <p9> [vrsn]0.90 :
                string answer = Console.ReadLine().ToLower();

                // <p9> [vrsn]0.90 :
                if (answer == "yes" || answer == "yeah")
                {
                    // <p9> [vrsn]0.90 :
                    player.IsActivelyPlaying = true;
                }

                // <p9> [vrsn]0.90 :
                else
                {
                    // <p9> [vrsn]0.90 :
                    player.IsActivelyPlaying = false;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotFiniteNumberException();
        }
    }
}
