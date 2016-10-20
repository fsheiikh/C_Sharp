using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_051_MegaChallengeWar.Domain
{
    [Serializable]
    public class Game
    {
        public Player player1 { get; set; }
        public Player player2 {get; set;}
        public Deck deck { get; set;}
        Random random = new Random();


        public Game()
        {
            deck = new Deck();
            deck.setDeck();
            deck.shuffleDeck(random);
        }


        //sets player instances . NEEDS TO BE REFACTORED (maybe use list of players instead)
        public void setPlayers(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);   
        }


        //splits deck in half and gives first half to first players and the other half to player 2
        public void splitDeckBetweenPlayers()
        {
            int halfOfDeck = deck.cards.Count / 2;
            player1.deck.cards = deck.cards.Take(halfOfDeck).ToList();
            player2.deck.cards = deck.cards.Skip(halfOfDeck).Take(halfOfDeck).ToList();
    
        }


        //get list of all cards in deck
        public string allCardsInDeck(List<Card> cards)
        {
            string result = "";
       
            foreach (Card card in cards)
            {
                result += "<img src=" + "Images/" + card.image + ">" 
                        + card.name + "<br>" + "<br>";
               
            }
            return result;
        }  
    }
}