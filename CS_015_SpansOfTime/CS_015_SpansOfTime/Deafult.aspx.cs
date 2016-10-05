using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_015_SpansOfTime
{
    public partial class Deafult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // http://is.gd/timespan
            // Days.Hours:Minutes:Seconds.Milliseconds

            TimeSpan myTimeSpan = TimeSpan.Parse("1.2:3:30.5");

            DateTime myBirthday = DateTime.Parse("1/11/1994");

            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

          

            Label1.Text = myAge.TotalDays.ToString();

        }
    }
}