using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_028_SimpleHelpers
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CalculateCups(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(TextBox1.Text, out quantity))
                return;

            double cups = 0.0;

           if (RadioButton1.Checked) cups = quantity;
            else if (RadioButton2.Checked) cups = quantity * 2;
            else if (RadioButton3.Checked) cups = quantity * 4;
           else if (RadioButton4.Checked) cups = quantity * 16;

            Label1.Text = cups.ToString();
        }

    }
}