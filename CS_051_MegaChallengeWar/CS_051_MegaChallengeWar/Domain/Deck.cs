using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_051_MegaChallengeWar.Domain
{

    interface IDeck
    {
        List<Card> deckOfCards { get; set; }
    }


    public class Deck : IDeck
    {
        public List<Card> deckOfCards { get; set; }
        

        public Deck()
        {
            deckOfCards = new List<Card>();
            setDeck();

        }
        
        //use enums to create 52 cards
        public void setDeck()
        {
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value v in Enum.GetValues(typeof(Value)))
                {
                    deckOfCards.Add(new Card {name= v + " of " + s, suit = s, value = v });
                }
            }
        }



        Random random = new Random();

        //fisher yates shuffle
        public void shuffleDeck()
        {
            
            for (int i = deckOfCards.Count; i > 1; i--)
            {
                int pos = random.Next(i);
                var x = deckOfCards[i - 1];
                deckOfCards[i - 1] = deckOfCards[pos];
                deckOfCards[pos] = x;
            }


        }


    }

   



}