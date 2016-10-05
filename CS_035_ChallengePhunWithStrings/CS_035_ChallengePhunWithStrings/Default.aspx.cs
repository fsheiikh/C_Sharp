using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_035_ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            Label1.Text = reverseString(Label1.Text);
            Label2.Text = reverseStringS(Label2.Text);
            Label3.Text = padString("Luke,Leia,Han,Chewbacca");
        }

        private string reverseStringS(string names)
        {
            string[] result;
            string resultNew= "";
            result = names.Split(',');
            Array.Reverse(result);
            foreach (string n in result)
            {
                resultNew += n + ",";
            }
            
            return resultNew.Remove(0, 1);
        }


        private string reverseString(string name)
        {
            string result = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                result += name[i];
            }

            return result;
        }

        private string padString(string names)
        {
            string[] result;
            string resultNew = "";
            int padding;
            result = names.Split(',');
            foreach (string n in result)
            {
                padding = (14 - n.Length)/2;
               resultNew += n.PadRight(14, '*').PadLeft(padding, '*') + "</br>";
            }
            return resultNew;
        }


    }
}