using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_021_StoringValuesInArrays
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string[] values = new string[5];
            //values[0] = TextBox1.Text;
            //values[1] = TextBox2.Text;
            //values[2] = TextBox3.Text;
            //values[3] = TextBox4.Text;
            //values[4] = TextBox5.Text;

            //Label1.Text = values[2];
            //Label1.Text = values.Length.ToString();

            string[] values = { "Sam", "Mo", "Norman", "Emmit", "Fred" };
            //Easy wyay V
            //Label1.Text = values[2];

            ViewState.Add("MyValues", values);
            Label1.Text = "Values Added";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string[] values = (string[])ViewState["MyValues"];
            TextBox1.Text = values[0];
            TextBox2.Text = values[2];

            Label1.Text = values[3];
        }
    }
}