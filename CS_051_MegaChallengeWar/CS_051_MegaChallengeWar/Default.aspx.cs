using CS_051_MegaChallengeWar;
using CS_051_MegaChallengeWar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_051_MegaChallengeWar
{
    public partial class Default : System.Web.UI.Page
    {   

        protected void Page_Load(object sender, EventArgs e)
        {
            //Card card = new Card { power=10, suit=Suit.Hearts, value=Value.King};

            //Label1.Text = card.power.ToString() + " " + card.suit + card.value;

            //Deck deck = new Deck();
            //if (deck.cards.FirstOrDefault().Value < deck.cards["second"])
            //    Label1.Text = "yes";

            //Deck deck = new Deck();
            //deck.initialize();
            //deck.deckOfCards = new List<Card>();
            //deck.setDeck();
            //Card card = deck.deckOfCards.FirstOrDefault();
            //deck.shuffleDeck();
            //Card card = deck.deckOfCards.Skip(3).FirstOrDefault();
            //int num = (int)card.value;
            // string num = card.name;

            Game game = new Game();
            game.setPlayers("Junto", "Punto");
            
            Label1.Text = game.deck.deckOfCards.FirstOrDefault().name.ToString();
            
            game.splitDeck();

            Label1.Text += "____" + game.deck.deckOfCards.FirstOrDefault().name.ToString();

            Label1.Text += "____" + game.player1.deck.deckOfCards.FirstOrDefault().name.ToString();
            Label1.Text += "____" + game.player2.deck.deckOfCards.FirstOrDefault().name.ToString();

            Label2.Text = game.allCardsInDeck(game.player1.deck);

            Label3.Text = game.allCardsInDeck(game.player2.deck);

            game.player2.deck.deckOfCards.RemoveAt(0);
            Label4.Text = game.allCardsInDeck(game.player2.deck);

            War war = new War();
            war.game = game;

            
                war.startWar(game.player1.deck.deckOfCards.FirstOrDefault(), game.player2.deck.deckOfCards.FirstOrDefault());

                Label5.Text += war.bounty1.name + "VS" + war.bounty2.name + "<br>" + "<br/>";

                Label5.Text += war.game.allCardsInDeck(game.player1.deck) + "<br>";

                Label5.Text += war.game.allCardsInDeck(game.player2.deck);
            

                

            



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}