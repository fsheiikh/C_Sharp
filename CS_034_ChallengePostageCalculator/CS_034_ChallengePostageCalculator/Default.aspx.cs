using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_034_ChallengePostageCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calculate(object sender, EventArgs e)
        {
           
                double width, height, length, total;
            if (validate()) {

            }
                Double.TryParse(Width.Text, out width);
                Double.TryParse(Height.Text, out height);
                Double.TryParse(Length.Text, out length);

                if (length == 0) total = calculateSize(width, height);
                else total = calculateSize(width, height, length);

                Label1.Text = String.Format("Total Cost for Shipping: {0:C}", total);
            
            
           
        }


        private double calculateSize(double width, double height, double length = 1)
        {
            double totalSize = width * height * length;
            return calculateShipping(totalSize);
        }


        private double calculateShipping(double dimensions)
        {
            double totalWithShipping = 0.0 ;

            if (Ground.Checked) totalWithShipping = dimensions * 0.15;
            else if (Air.Checked) totalWithShipping = dimensions * 0.25;
            else if (NextDay.Checked) totalWithShipping = dimensions * 0.45;

            return totalWithShipping;
        }

        private bool validate()
        {
            if ((Width.Text == "") || Height.Text == "") return false;
            //add logic to make sure input is double
            return true;
        }

       
    }
}