using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_014_DateTime
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime myValue = DateTime.Now;
            //Label1.Text = myValue.ToString();
            //Label1.Text = myValue.ToShortDateString();

            //Label1.Text = myValue.AddDays(2).ToString();

            //Label1.Text = myValue.Month.ToString();

            //Label1.Text = myValue.ToShortDateString();
            //Label1.Text = myValue.DayOfWeek.ToString();

            //DateTime newvalue = DateTime.Parse("01/11/1994");
            DateTime newvalue = new DateTime(1994, 11, 1);
            Label1.Text = newvalue.ToLongDateString();
        }
    }
}