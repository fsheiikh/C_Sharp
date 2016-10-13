using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_051_MegaChallengeWar.Domain
{
    public class Game
    {
        public Player player1 { get; set; }
        public Player player2 {get; set;}

        public Deck deck { get; set;}

        public Game()
        {
            deck = new Deck();
            deck.shuffleDeck();
        }

        //sets player instances and initiliazes decks. NEEDS TO BE REFACTORED 
        public void setPlayers(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);
            
        }


        public void splitDeck()
        {   
            player1.deck.deckOfCards = (deck.deckOfCards.Take(26)).ToList();

            player2.deck.deckOfCards = (deck.deckOfCards.Skip(26).Take(26)).ToList();

            
        }

        public string allCardsInDeck(Deck deck)
        {
            string result = "";

            foreach (Card card in deck.deckOfCards)
            {
                result += card.name + "<br>";

            }

            return result;

        }

       
    }
}