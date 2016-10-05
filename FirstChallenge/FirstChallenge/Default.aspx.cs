using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string age = TextBox1.Text;
            string money = TextBox2.Text;

            Label1.Text = "At " + age + " I would expect you to have more than $" + money + " in your pocket";

            TextBox1.Text =" ";
            TextBox2.Text = " ";
            Button1.CssClass = "btn btn-danger";
            Button1.Text = "Ouch!";

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
