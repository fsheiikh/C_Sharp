using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_034_ChallengeCasino
{
    

    public partial class Default : System.Web.UI.Page
    {

        //double totalMoney;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                //totalMoney = 100.0;
                //Label1.Text = totalMoney.ToString();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] currentImages;
            double myBet = checkForDouble(TextBox1.Text);

            if (validateValues(myBet)) {
                currentImages = randomizeImages();
                checkVaueOfImages(currentImages, myBet);
            }
   
        }

       
        //if used as getter, number will equal 0 so that label will not change
        private double totalMoney(double number = 0)
        {
            double totalMoney;
            Double.TryParse(Label1.Text, out totalMoney);
            double newTotal = totalMoney + number;
            Label1.Text = String.Format("{0}", newTotal);
            return totalMoney;
        }

        //checks to make sure the value entered is valid based on current amount 
        private bool validateValues(double myBet)
        { 
            if (myBet <= 0.0 || (totalMoney() <= myBet) || totalMoney() <= 0.0)
            {
                Label2.Text = "Invalid Bet Amount";
                Label2.CssClass = "black";
                return false;
            }
            else return true;
        }

        //checks for number of cherries, sevens, bars
        private void checkVaueOfImages(string[] images, double myBet)
        {
            int cherries = 0, sevens = 0, bar = 0;

            for (int i = 0; i < images.Length; i++) {

                if (images[i] == "Cherry") cherries++;
                else if (images[i] == "Seven") sevens++;
                else if (images[i] == "Bar") bar++;
            }
            calculateWithValues(cherries, sevens, bar, myBet);
        }


        //updates totalMoney() and total money label based on money bet 
        private void calculateWithValues(int cherries, int sevens, int bar, double myBet)
        {
            double myBetBeforeCalc = myBet;

            //totalMoney(myBet*-1) is same as totalMoney -= myBet
            if (bar >= 1) totalMoney(myBet*=-1);
            else if (sevens == 3.0) totalMoney(myBet*=100);
            else if (cherries == 1.0) totalMoney(myBet*=2);
            else if (cherries == 2.0) totalMoney(myBet*=3);
            else if (cherries == 3.0) totalMoney(myBet*=4);
            else totalMoney(myBet *= -1);
            // method call below passes the total amount, the bet after calculaton, and the inital bet amount
            updateCurrentbetLabel(totalMoney(), myBet, myBetBeforeCalc);
        }

        //updates the label that displays money won and lost from bet
        private void updateCurrentbetLabel(double totalMoney, double myBet, double myBetBeforeCalc)
        {
            if ((-1 * myBetBeforeCalc) == myBet)
            {
                Label2.Text = String.Format("Sorry, You Lost ${0}", myBet * -1);
                Label2.CssClass = "red";
            }

            else if (myBetBeforeCalc <= myBet)
            {
                Label2.Text = String.Format("Congratulations, you bet ${0} and won ${1}", myBetBeforeCalc, myBet);
                Label2.CssClass = "green";
            } 
        }

        //takes in inout from textbox and returns double value
        private double checkForDouble(string myBet)
        {
            double betAmount;
            bool isDouble = Double.TryParse(myBet, out betAmount);

            if (isDouble && (betAmount <= totalMoney())) return betAmount;
            else return 0.0;
        }


        private string[] randomizeImages()
        {
            string[] image;
            image = spinReel();
            Image1.ImageUrl = "~/" + image[0] + ".png";
            Image2.ImageUrl = "~/" + image[1] + ".png";
            Image3.ImageUrl = "~/" + image[2] + ".png";
            return image;
        }

        
        Random random = new Random();

        private string[] spinReel()
        {
            string[] images = new string[] { "Strawberry", "Bar", "Lemon", "Bell", "Clover", "Cherry", "Diamond", "Orange", "Seven", "HorseShoe", "Plum", "Watermelon" };
            string[] newImages = { images[random.Next(11)], images[random.Next(11)], images[random.Next(11)] };
            return newImages;
        }

        
    }
}