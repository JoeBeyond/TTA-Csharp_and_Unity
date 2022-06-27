using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21BlackJackGame
{
    public class TwentyOneDealer : Dealer // <p2> [vrsn]0.90 :[TwentyOneDealer] Class Inherits from [Dealer] Class
    {
        // <p10> [vrsn]0.90 :
        private List<Card> _hand = new List<Card>();

        // <p2> [vrsn]0.90 :// <p10> [vrsn]0.90 :State; Property [Hand] is inside List<Card> and provides a State for Object [TwentyOneDealer]
        // with 2 Methods, get; and set;. Get [Hand] and set [Hand].
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }

        // <p2> [vrsn]0.90 :State; Property [Stay] is a Bool with 2 Methods.
        public bool Stay { get; set; }

        // <p2> [vrsn]0.90 :State; Property [IsBusted] is a bool with 2 Methods.
        public bool IsBusted { get; set; }
    }
}
