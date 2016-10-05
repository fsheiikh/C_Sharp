using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_019_ChallengeEpicSpies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Calendar1.SelectedDate = DateTime.Today;

                Calendar2.SelectedDate = Calendar1.SelectedDate.AddDays(14);
                Calendar2.VisibleDate = Calendar2.SelectedDate;

                Calendar3.SelectedDate = Calendar2.SelectedDate.AddDays(7);
                Calendar3.VisibleDate = Calendar3.SelectedDate;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TimeSpan untilAssignment = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate);
            TimeSpan currentAssignment = Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate);

            double cost = (currentAssignment.TotalDays >= 21) ? 
                currentAssignment.TotalDays * 500 + 1000 : 
                currentAssignment.TotalDays * 500;

            //Label1.Text = (untilAssignment.TotalDays < 14) ? "ERROR: NEED AT LEAST 2 WEEKS BETWEEN ASSIGNMENTS! " : " ";
            //Label1.Text = (currentAssignment.TotalDays <= 1) ? Label1.Text + " ERROR: NEED MORE TIME TO COMPLETE ASSIGNMENT" : Label1.Text + " ";

            Label1.Text = (!(untilAssignment.TotalDays < 14) && !(currentAssignment.TotalDays <= 1) && (Assignment.Text != "")) ?
                "Assignment of " + Name.Text + " to assignment " + Assignment.Text + " is authorized. " + "Budget total: $" + cost.ToString() : 
                "ERROR IN DATES SELECTED or TEXT FIELDS";
            
        }
    }
}