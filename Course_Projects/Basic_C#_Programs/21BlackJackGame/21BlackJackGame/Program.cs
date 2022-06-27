using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21BlackJackGame
{
    class Program
    {
        // START HERE on <p1> and work upwards ++ from <p1> i.e. <p2> --> <p3>; <p0> is an earlier version(s) before 0.90 implemented into the Program.
        static void Main(string[] args)
        {
            // <p1> [vrsn]0.90 :Introduction to the program; Writes the the console the message and creates a variable [playerName]
            // with string data-type through which user input can be taken and used to give value to the variable.
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            // <p1> [vrsn]0.90 :Writes to the console a string, and creates an variable [bank] with integer data-type through
            // which the user input that gives value to the variable, is converted to an int because the default data-type for
            // variables is string.
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            // <p1> [vrsn]0.90 :Writes to the console a line of text which pulls data from the variable [playerName] and displays that
            // to the console, and the next thing, a variable [answer] with data-type string is created through which user input
            // is converted to lowercase and then gives value to the variable.
            Console.WriteLine("Hello {0}, would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            // <p1> [vrsn]0.90 : After the first variables are created and assigned values, then Main() will initialize a loop
            // that will check [answer] against 4 possible responses; IF the response is == one of the 4 strings, then the loop will begin.
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                // <p1> [vrsn]0.90 : Initalize a new player; Object [player] from Class [Player] has a value defined with Variables
                // [playerName] and [bank] which IR (inference/reference) from the Parameters in Class [Player.Player].
                Player player = new Player(playerName, bank);

                // <p1> [vrsn]0.90 : Initialize a new [game] of [Game] Class that is ALSO a new TwentyOneGame(), game; Polymorphism.
                Game game = new TwentyOneGame();

                // <p1> [vrsn]0.90 : Add a new [player] Object to the [game]; [game] is equal to [game] plus [player].
                game += player;

                // <p1> [vrsn]0.90 : Player is actively playing the game; the game will continue to function until bool switches.
                player.IsActivelyPlaying = true;

                // <p1> [vrsn]0.90 : WHILE, player is [IsActivelyPlaying] AND the balance of the player is greater than 0 then this loop
                // will continue to operate.
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    // <p1> [vrsn]0.90 : Play Method initilaization, this is where the majority of the program will take place i.e. TwentyOneGame.cs
                    game.Play();
                }

                // <p2> [vrsn]0.90 :When the player exits the While loop, and in turn [IsActivelyPlaying] would be false, then subtract the player from the game.
                game -= player;

                // <p2> [vrsn]0.90 :Print message to console.
                Console.WriteLine("Thank you for playing!");
            }

            // <p2> [vrsn]0.90 :Print message to console if user input anything else other than the accepted reponses equal to [answer] in the
            // IF loop on Line 32.
            Console.WriteLine("Feel free to look around the casino. Bye for now!");

            // <p2> [vrsn]0.90 :Create a NON-INPUT hold before exiting the program.
            Console.Read();
        }
    }
}
