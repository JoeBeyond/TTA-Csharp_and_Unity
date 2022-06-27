using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21BlackJackGame
{
    // <p4> [vrsn]0.90 :
    public class TwentyOneRules 
    {
        // <p4> [vrsn]0.90 :
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            // <p5> [vrsn]0.90 :All Faces
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        // <p5> [vrsn]0.90 :
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            // <p5> [vrsn]0.90 :
            int aceCount = Hand.Count(x => x.Face == Face.Ace);

            // <p5> [vrsn]0.90 :
            int[] result = new int[aceCount + 1];

            // <p5> [vrsn]0.90 :
            int value = Hand.Sum(x => _cardValues[x.Face]);

            // <p5> [vrsn]0.90 :
            result[0] = value;

            // <p5> [vrsn]0.90 :
            if (result.Length == 1)
            {
                return result;
            }

            // <p6> [vrsn]0.90 :
            for (int i = 1; i < result.Length; i++)
            {
                // <p6> [vrsn]0.90 :
                value += (i * 10);

                // <p6> [vrsn]0.90 :
                result[i] = value;
            }

            // <p6> [vrsn]0.90 :
            return result;
        }

        // <p5> [vrsn]0.90 :
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            // <p6> [vrsn]0.90 :
            int[] possibleValues = GetAllPossibleHandValues(Hand);

            // <p6> [vrsn]0.90 :
            int value = possibleValues.Max();

            // <p6> [vrsn]0.90 :
            if (value == 21) return true;

            // <p6> [vrsn]0.90 :
            else return false;
        }

        // <p7> [vrsn]0.90 :
        public static bool IsBusted(List<Card> Hand)
        {
            // <p7> [vrsn]0.90 :
            int value = GetAllPossibleHandValues(Hand).Min();

            // <p7> [vrsn]0.90 :
            if (value > 21) return true;

            // <p7> [vrsn]0.90 :
            else return false;
        }

        // <p7> [vrsn]0.90 :
        public static bool ShouldDealerStay(List<Card> Hand)
        {

            // <p8> [vrsn]0.90 :
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);

            // <p8> [vrsn]0.90 :
            foreach (int value in possibleHandValues)
            {
                // <p8> [vrsn]0.90 :
                if (value > 16 && value < 22)
                {
                    // <p8> [vrsn]0.90 :
                    return true;
                }
            }

            // <p8> [vrsn]0.90 :
            return false;
        }

        // <p9> [vrsn]0.90 :
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            // <p9> [vrsn]0.90 :
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);

            // <p9> [vrsn]0.90 :
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            // <p9> [vrsn]0.90 :
            int playerScore = playerResults.Where(x => x < 22).Max();

            // <p9> [vrsn]0.90 :
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            // <p9> [vrsn]0.90 :
            if (playerScore > dealerScore) return true;

            // <p9> [vrsn]0.90 :
            if (playerScore < dealerScore) return false;

            // <p9> [vrsn]0.90 :
            else return null;
        }
    }
}
