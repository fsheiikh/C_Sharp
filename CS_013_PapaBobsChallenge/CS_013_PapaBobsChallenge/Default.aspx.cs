using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_013_PapaBobsChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        double total;

        protected void Page_Load(object sender, EventArgs e)
        {
            total = 0.0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Radio_10.Checked)
            {
                total += 10.0;
            }
            else if (Radio_13.Checked)
            {
                total += 13.00;
            }
            else if (Radio_16.Checked) {
                total += 16.00;
            }

            total += (Radio_thin.Checked) ? 0.00 : 2.00;

            total += (CheckBox1.Checked) ? 1.50 : 0.00;
            total += (CheckBox2.Checked) ? 0.75 : 0.00;
            total += (CheckBox3.Checked) ? 0.50 : 0.00;
            total += (CheckBox4.Checked) ? 0.75 : 0.00;
            total += (CheckBox5.Checked) ? 2.00 : 0.00;

            //1, 3, 5 OR 1, 4, 2
            //below if check makes sure the deal for $2 off is satisfied
            if ((CheckBox1.Checked && CheckBox3.Checked && CheckBox5.Checked &&
                !CheckBox2.Checked &&!CheckBox4.Checked) ||

                (CheckBox1.Checked && CheckBox2.Checked && CheckBox4.Checked &&
                !CheckBox3.Checked && !CheckBox5.Checked)) {

                total -= 2.00;
            }

            Label1.Text = "$" + total.ToString();
        }

        
    }
}