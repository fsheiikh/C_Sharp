using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_016_CalenderControl
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Calendar1.SelectedDate = DateTime.Parse("9/18/2016");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Calendar1.VisibleDate = DateTime.Parse("1/11/2009");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //nee dothcage selected
            //Label1.Text = "Week of" + Calender1.SelctedDat.TOShort DateString();
        }
    }
}