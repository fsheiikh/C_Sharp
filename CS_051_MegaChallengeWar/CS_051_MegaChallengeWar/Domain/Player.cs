using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_051_MegaChallengeWar.Domain
{
    [Serializable]
    public class Player
    {
        public string name { get; set;}
        public Deck deck { get; set;}

        public Player(string playerName)
        {
            name = playerName;
            deck = new Deck();

        }

    }
}