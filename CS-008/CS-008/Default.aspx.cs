using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_008
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* long i = 20000000;
             int j = (int)i;

             double k = 2.5;
             int j = int(k);
             */
            string i = TextBox1.Text;
            int j = int.Parse(i);

            Label1.Text = j.ToString();

        }
    }
}