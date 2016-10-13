using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_051_MegaChallengeWar
{
    interface ICard
    {
        string name { get; set; }
    }


    public class Card : ICard
    {   
        public string name {get; set;}
        public Suit suit { get; set;}
        public Value value { get; set;}

    }

    public enum Suit
    {
        Hearts,
        Spaids,
        Diamonds,
        Clubs
    }

    public enum Value
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10, 
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }
}