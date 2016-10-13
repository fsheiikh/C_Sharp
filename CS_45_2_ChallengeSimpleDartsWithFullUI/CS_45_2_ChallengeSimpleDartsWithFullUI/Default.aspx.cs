using CS_045_ChallengeSimpleDartsWithFullUI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CS_45_2_ChallengeSimpleDartsWithFullUI
{
    public partial class Default : System.Web.UI.Page
    {
        Game game;
   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                game = new Game();
                ViewState["Game"] = game;
                
            }
            resetBoard();

        }


        

        protected void Player1Throw_Click(object sender, EventArgs e)
        {  
            game = (Game)ViewState["Game"];

            if (PlayerOneTurn() > 0)
            {
                int[] results = game.Play(1);
                playerOneTotalLabel.Text = "Player 1 Score: " + game.playerOneScore.ToString();
                ShowResults(results);
            }
            else {
                determineWinner(game.playerOneScore, game.playerTwoScore);
            }

        }



        protected void Player2Throw_Click(object sender, EventArgs e)
        {
            game = (Game)ViewState["Game"];

            if (PlayerTwoTurn() > 0)
            {
                int[] results = game.Play(2);
                playerTwoTotalLabel.Text = "Player 2 Score: " + game.playerTwoScore.ToString();
                ShowResults(results);
            }
            else
            {
                determineWinner(game.playerOneScore, game.playerTwoScore);
            }
        }





        private void determineWinner(int Player1Score, int Player2Score)
        {
            if (PlayerTwoTurn() <= 0 && PlayerOneTurn() <= 0)
            {
                WinnerLabel.Text = (Player1Score > Player2Score) ? "Player 1 Wins!" : "Player 2 Wins!";

            }
            else {

                WinnerLabel.Text = "Still Turns Remaining";
            }
        }


        private int PlayerOneTurn()
        {
            int turns = Int32.Parse(P1TurnsLabel.Text);
            turns--;
            P1TurnsLabel.Text = (turns > 0) ? turns.ToString() : " 0";
            return turns;
        }

        private int PlayerTwoTurn()
        {
            int turns = Int32.Parse(P2TurnsLabel.Text);
            turns--;
            P2TurnsLabel.Text = (turns > 0) ? turns.ToString() : " 0";
            return turns;
        }




        //recieve array from PlayerThrow methods containing [score, outer, inner]
        private void ShowResults(int[] results)
        {   
            
            int score = results[0];
            int outer = results[1];
            int inner = results[2];

            currentThrowLabel.Text =  (score != 0) ? score.ToString() : "25" ;


            BonusLabel.Text = (outer == 1) ? " x 2 - Hit Outer Band" : " ";
            BonusLabel.Text = (inner == 1) ? " x 3 - Hit Inner Band" : " ";

            if (score == 0) DIV_116.Attributes["class"] = "yellowbg";
            else if(score == 1) DIV_18.Attributes["class"] = "yellow";
            else if (score == 2) DIV_29.Attributes["class"] = "yellow";
            else if (score == 3) DIV_27.Attributes["class"] = "yellow";
            else if (score == 4) DIV_20.Attributes["class"] = "yellow";
            else if (score == 5) DIV_16.Attributes["class"] = "yellow";
            else if (score == 6) DIV_22.Attributes["class"] = "yellow";
            else if (score == 7) DIV_25.Attributes["class"] = "yellow";
            else if (score == 8) DIV_23.Attributes["class"] = "yellow";
            else if (score == 9) DIV_14.Attributes["class"] = "yellow";
            else if (score == 10) DIV_31.Attributes["class"] = "yellow";
            else if (score == 11) DIV_12.Attributes["class"] = "yellow";
            else if (score == 12) DIV_15.Attributes["class"] = "yellow";
            else if (score == 13) DIV_21.Attributes["class"] = "yellow";
            else if (score == 14) DIV_13.Attributes["class"] = "yellow";
            else if (score == 15) DIV_30.Attributes["class"] = "yellow";
            else if (score == 16) DIV_24.Attributes["class"] = "yellow";
            else if (score == 17) DIV_28.Attributes["class"] = "yellow";
            else if (score == 18) DIV_19.Attributes["class"] = "yellow";
            else if (score == 19) DIV_14.Attributes["class"] = "yellow";
            else if (score == 19) DIV_26.Attributes["class"] = "yellow";
            else if (score == 20) DIV_17.Attributes["class"] = "yellow";
        }



        private void resetBoard()
        {
             DIV_116.Attributes["class"] = "default";
             DIV_117.Attributes["class"] = "default2";
             DIV_116.Attributes["class"] = "default";
             DIV_18.Attributes["class"] = "default3";
             DIV_29.Attributes["class"] = "default3";
             DIV_27.Attributes["class"] = "default3";
             DIV_20.Attributes["class"] = "default3";
             DIV_16.Attributes["class"] = "default3";
             DIV_22.Attributes["class"] = "default3";
             DIV_25.Attributes["class"] = "default3";
             DIV_23.Attributes["class"] = "default3";
             DIV_14.Attributes["class"] = "default3";
             DIV_31.Attributes["class"] = "default3";
             DIV_12.Attributes["class"] = "default3";
             DIV_15.Attributes["class"] = "default3";
             DIV_21.Attributes["class"] = "default3";
             DIV_13.Attributes["class"] = "default3";
             DIV_30.Attributes["class"] = "default3";
             DIV_24.Attributes["class"] = "default3";
             DIV_28.Attributes["class"] = "default3";
             DIV_19.Attributes["class"] = "default3";
             DIV_14.Attributes["class"] = "default3";
             DIV_26.Attributes["class"] = "default3";
             DIV_17.Attributes["class"] = "default3";
        }
    }
}