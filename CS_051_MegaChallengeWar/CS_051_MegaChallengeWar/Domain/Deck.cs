using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_051_MegaChallengeWar.Domain
{
    
    interface IDeck
    {
        List<Card> cards { get; set; }
    }

    [Serializable]
    public class Deck : IDeck
    {
        public List<Card> cards { get; set; }
        

        public Deck()
        {
            cards = new List<Card>();
        }
        

        //use enums to create 52 cards, Not in constructor because players have different decks
        public void setDeck()
        {
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value v in Enum.GetValues(typeof(Value)))
                {
                    cards.Add(new Card {name= v + " of " + s, suit = s, value = v , image = v + "" +  s + ".png"});
                }
            }
        }


        //fisher yates shuffle
        public void shuffleDeck(Random random)
        {
            
            for (int i = cards.Count; i > 1; i--)
            {
                int pos = random.Next(i);
                var x = cards[i - 1];
                cards[i - 1] = cards[pos];
                cards[pos] = x;
            }
        }
    }

}