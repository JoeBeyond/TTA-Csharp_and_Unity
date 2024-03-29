﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21BlackJackGame
{
    public struct Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        // <p7> [vrsn]0.90 :
        public override string ToString()
        {
            // <p7> [vrsn]0.90 :
            return string.Format("{0} of {1}", Face
                , Suit);
        }
    }

    

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
