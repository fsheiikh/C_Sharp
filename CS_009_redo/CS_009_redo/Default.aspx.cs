using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_009_redo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i;
            bool test = int.TryParse(TextBox1.Text, out i);
            bool test2 = int.TryParse(TextBox2.Text, out i);

            if (test && test2)
            {
                int number1 = int.Parse(TextBox1.Text);
                int number2 = int.Parse(TextBox2.Text);
                int sum = number2 + number1;

                Label1.Text = sum.ToString();
                Label1.CssClass = "card blue darken - 1";
            }
            else {
                Label1.Text = "Not a nmber";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(TextBox1.Text);
            int number2 = int.Parse(TextBox2.Text);
            int sum;

            if (number1 > number2)
            {
                sum = number1 - number2;
            }
            else {
                sum = number2 - number1;
            }

            Label1.Text = sum.ToString();
            Label1.CssClass = "card green darken - 1";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(TextBox1.Text);
            int number2 = int.Parse(TextBox2.Text);
            int sum = number2 * number1;
            Label1.Text = sum.ToString();
            Label1.CssClass = "card red darken - 1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(TextBox1.Text);
            float number2 = float.Parse(TextBox2.Text);
            float sum = number1 / number2;
            Label1.Text = sum.ToString();
            Label1.CssClass = "card yellow darken - 1";
        }
    }
}