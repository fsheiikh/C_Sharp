using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_012_ChallengeRadio
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioPencil.Checked)
            {
                Label1.Text = "Pencil";
                Image1.ImageUrl = "pencil.png";
            }
            else if (RadioPen.Checked)
            {
                Label1.Text = "Pen";
                Image1.ImageUrl = "pen.png";
            }
            else if (RadioPhone.Checked)
            {
                Label1.Text = "Phone";
                Image1.ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQtakdbe4qm-WDqTrPLK0cCLT33kTkPthXeFqAigZh6eVh5VjJ_";
            }
            else if (RadioTablet.Checked)
            {
                Label1.Text = "Tablet";
                Image1.ImageUrl = "http://simpleicon.com/wp-content/uploads/tablet-1-256x256.png";
            }
            else {
                Label1.Text = "Please select one";

            }

        }
    }
}