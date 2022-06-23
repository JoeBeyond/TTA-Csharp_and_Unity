﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21BlackJackGame
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();

            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }

            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);

                if (!successfullyBet)
                {
                    return;
                }

                Bets[player] = bet;
            }

            for (int turn = 0; turn < 2; turn++)
            {
                Console.WriteLine("Dealing...");

                foreach (Player player in Players)
                {
                    Console.WriteLine("{0}",player.Name);
                    Dealer.Deal(player.Hand);

                    if (turn == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            Bets.Remove(player);
                            return;
                        }
                    }
                }

                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);

                if (turn == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");

                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                }
            }

            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");

                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }

                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }

                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }

                    bool busted = TwentyOneRules.IsBusted(player.Hand);

                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();

                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                        }
                    }
                }
            }

            Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            while (!Dealer.Stay && !Dealer.IsBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }

            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying");

                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }

                return;
            }

            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);

                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }

                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }

                else
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();

                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }

                else
                {
                    player.isActivelyPlaying = false;
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
