using CS_045_ChallengeSimpleDarts.Domain;
using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_045_ChallengeSimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Play();

            Label1.Text = "Player 1 Score: " + game.playerOneScore.ToString();
            Label2.Text = "Player 2 Score: " + game.playerTwoScore.ToString();



        }
    }
}