using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_051_MegaChallengeWar.Domain
{
    public class War
    {
        public Game game { get; set; }
        public Card bounty1 { get; set; }
        public Card bounty2 { get; set; }

        //cardsRisk are the range of cards from either deck that are on the line in a war
        List<Card> cardsRisk1 { get; set; }
        List<Card> cardsRisk2 { get; set; }

        


        public string startWar(Card player1Card, Card player2Card)
        {
            bounty1 = player1Card;
            bounty2 = player2Card;

            if ((int)bounty1.value > (int)bounty2.value)
            {
                game.player1.deck.deckOfCards.Add(bounty2);
                game.player2.deck.deckOfCards.Remove(bounty2);

                game.player1.deck.deckOfCards.Remove(bounty1);
                game.player1.deck.deckOfCards.Add(bounty1);
                return "Player 1 Wins";
            }
            else if ((int)bounty1.value < (int)bounty2.value)
            {
                game.player2.deck.deckOfCards.Add(bounty1);
                game.player1.deck.deckOfCards.Remove(bounty1);

                game.player2.deck.deckOfCards.Remove(bounty2);
                game.player2.deck.deckOfCards.Add(bounty2);
                return "Player 2 Wins";

            }
            else if ((int)bounty1.value == (int)bounty2.value)
            {
                tiedWar(player1Card, player2Card);
                

            }

            return " ";

        }

        public void tiedWar(Card player1Card, Card player2Card)
        {
            int cardLocation = game.player1.deck.deckOfCards.FindIndex(c => c == player1Card);
            int cardLocation2 = game.player2.deck.deckOfCards.FindIndex(c => c == player1Card);
            int bountyIndex1, bountyIndex2;

            bounty1 = game.player1.deck.deckOfCards.Skip(cardLocation+3).Take(1).Single();
            bounty2 = game.player2.deck.deckOfCards.Skip(cardLocation2+3).Take(1).Single();

            bountyIndex1 = game.player1.deck.deckOfCards.FindIndex(c => c == bounty1);
            cardsRisk1 = game.player1.deck.deckOfCards.GetRange(0, bountyIndex1 - 1);

            bountyIndex2 = game.player2.deck.deckOfCards.FindIndex(c => c == bounty2);
            cardsRisk2 = game.player1.deck.deckOfCards.GetRange(0, bountyIndex2 - 1);


            if (startWar(bounty1, bounty2) == "Player 1 Wins")
            {

                game.player1.deck.deckOfCards.RemoveRange(0, bountyIndex1 - 1);
                game.player1.deck.deckOfCards.AddRange(cardsRisk1);
                game.player1.deck.deckOfCards.AddRange(cardsRisk2);

                game.player2.deck.deckOfCards.RemoveRange(0, bountyIndex2 - 1);
            }
            else if (startWar(bounty1, bounty2) == "Player 2 Wins")
            {
                game.player2.deck.deckOfCards.RemoveRange(0, bountyIndex2 - 1);
                game.player2.deck.deckOfCards.AddRange(cardsRisk2);
                game.player2.deck.deckOfCards.AddRange(cardsRisk1);

                game.player1.deck.deckOfCards.RemoveRange(0, bountyIndex1 - 1);
            }
           


        }




    }
}