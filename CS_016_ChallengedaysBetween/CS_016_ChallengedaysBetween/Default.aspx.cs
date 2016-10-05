using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_016_ChallengedaysBetween
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        //    DateTime firstDate = Calendar1.SelectedDate;
        //    DateTime secondDate = Calendar2.SelectedDate;

            TimeSpan elapsedTime = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate);
            Label1.Text = Math.Abs(elapsedTime.TotalDays).ToString() + " Days have elapsed";
        }
    }
}