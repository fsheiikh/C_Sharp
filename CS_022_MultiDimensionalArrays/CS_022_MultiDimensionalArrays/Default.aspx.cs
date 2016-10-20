using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_022_MultiDimensionalArrays
{
    public partial class Default : System.Web.UI.Page
    {
        double[,] priceGrid;
        protected void Page_Load(object sender, EventArgs e)
        {
            //double[,] priceGrid = new double[3, 3];
            //0 - Chicago
            //1 -nY
            //2 - London
            priceGrid = new double[3, 3];
            priceGrid[0, 1] = 350.0;
            priceGrid[0, 2] = 750.0;
            priceGrid[1, 0] = 400.0;
            priceGrid[1, 2] = 700d;
            priceGrid[2, 0] = 800d;
            priceGrid[2, 1] = 850d;

            Label1.Text = priceGrid[1, 2].ToString();
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int fromCity;
            if (RadioButton1.Checked)
            {
                fromCity = 1;
            }
            else if (RadioButton2.Checked)
            {
                fromCity = 2;
            }
            else {
                fromCity = 3;
            }

            int toCity;
            if (RadioButton4.Checked)
            {
                toCity = 1;
            }
            else if (RadioButton5.Checked)
            {
                toCity = 2;
            }
            else {
                toCity = 3;
            }
            System.Diagnostics.Debug.WriteLine(priceGrid.ToString());
            Label1.Text = (fromCity == toCity) ? "Invalid" : priceGrid[fromCity, toCity].ToString();
        }
    }
}