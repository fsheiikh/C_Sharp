using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_011_ifelse
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (int.Parse(TextBox1.Text) == int.Parse(TextBox2.Text))
            //{
            //    Label1.Text = "same";
            //}
            //else
            //{
            //    Label1.Text = "not same";
            //}

            if (RadioButton1.Checked) {
                Label1.Text = "Pizza";
            }
            else if (RadioButton2.Checked) {
                Label1.Text = "Salad";
            }
            else if (RadioButton3.Checked)
            {
                Label1.Text = "bURGERS";
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Label2.Text = "Yes, You are cool";
            }
            else {
                Label2.Text = "No, you're lame";
            }
        }
    }
}