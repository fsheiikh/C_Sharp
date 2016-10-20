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
        Random random = new Random();
        War war;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Game game = new Game();
                game.setPlayers("Player1", "Player 2");
                game.splitDeckBetweenPlayers();

                war = new War(game);

                ViewState["War"] = war;

            }
            else
            {   
                var war = (War)ViewState["War"];
                displayDeckTotals();

            }
        }



        protected void Button1_Click1(object sender, EventArgs e)
        {
            var war = (War)ViewState["War"];
            if (!isDeckEmpty()) return;

            war.setBounty();
            displayDeckTotals();
            displayBucketAndBounty();
            setImages();
            
        }


        protected void Button2_Click(object sender, EventArgs e)
        {   
            var war = (War)ViewState["War"];

            if (!isGameReady()) return;
            else
            {
                Label5.Text += war.startWar() + "<br>";
                displayDeckTotals();
                displayBucketAndBounty();
            }
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            if (!isDeckEmpty()) return;
            shuffleDecks(random);
            displayDeckTotals();
        }



        public void shuffleDecks(Random random)
        {
            var war = (War)ViewState["War"];
            war.game.player1.deck.shuffleDeck(random);
            war.game.player2.deck.shuffleDeck(random);
        }


        public void displayDeckTotals()
        {
            var war = (War)ViewState["War"];
            Label1.Text = war.game.allCardsInDeck(war.game.player1.deck.cards);
            Label2.Text = war.game.allCardsInDeck(war.game.player2.deck.cards);
        }


        public void displayBucketAndBounty()
        {
            var war = (War)ViewState["War"];
            Label3.Text = war.getTestCards() + "<br>";
            Label4.Text = war.getBucket() + "<br>";
        }


        public bool isGameReady()
        {
            var war = (War)ViewState["War"];
            if (war.testCard1 !=null && war.testCard2 != null)
                return true;
            else return false;
        }


        public bool isDeckEmpty()
        {
            var war = (War)ViewState["War"];
            if (war.game.player1.deck.cards.Count >= 1 && war.game.player2.deck.cards.Count >= 1)
                return true;
            else return false;
        }

        public void setImages()
        {
            var war = (War)ViewState["War"];
            Image1.ImageUrl = "~/Images/" + war.testCard1.image;
            Image2.ImageUrl = "~/Images/" + war.testCard2.image;
        }
    }
}
