using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_023_ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                double[] subterfuge = new double[0];
                ViewState.Add("Subterfuge", subterfuge);

                double[] electionsRigged = new double[0];
                ViewState.Add("ElectionsRigged", electionsRigged);

                string[] assetName = new string[0];
                ViewState.Add("AssetName", assetName);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "") {


                double[] subterfuge = (double[])ViewState["Subterfuge"];
                Array.Resize(ref subterfuge, subterfuge.Length + 1);
                subterfuge[subterfuge.Length - 1] = double.Parse(TextBox3.Text);
                ViewState["Subterfuge"] = subterfuge;
                Label2.Text = String.Format("The AVG acts of subterfuge per asset: {0}", (subterfuge.Sum() / subterfuge.Length).ToString("N2"));

                double[] electionsRigged = (double[])ViewState["ElectionsRigged"];
                Array.Resize(ref electionsRigged, electionsRigged.Length + 1);
                electionsRigged[electionsRigged.Length - 1] = double.Parse(TextBox2.Text);
                ViewState["ElectionsRigged"] = electionsRigged;
                Label1.Text = String.Format("Total Elections rigged is: {0}", electionsRigged.Sum());

                string[] assetName = (string[])ViewState["AssetName"];
                Array.Resize(ref assetName, assetName.Length + 1);
                assetName[assetName.Length - 1] = TextBox1.Text;
                ViewState["AssetName"] = assetName;
                Label3.Text = "Last Asset you added was: " + assetName[assetName.Length - 1];

                Label4.Text = " ";
            } 
            else{
                Label4.Text = "Missing Field";
            }
        }

       

    }


}