﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_012
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = (TextBox1.Text == TextBox2.Text) ? "Yes" : "No";
            Label1.Text = (CheckBox1.Checked) ? "Checked" : "Not Checked";

        }
    }
}