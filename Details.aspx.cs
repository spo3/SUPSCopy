using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Details : System.Web.UI.Page
{
    string[,] a = new string[20, 20];
    protected void Page_Load(object sender, EventArgs e)
    {
        int selection = Convert.ToInt32(Session["UserDetailSelection"]);
        
        Response.Write(Session["UserDetailSelection"]);
        try
        {
            int k = 0;

            for (int i = 0; i < 20; i++)
            {
                ++k;
                for (int j = 0; j <= 7; j++)
                {
                    a[i, j] = Session["results" + k + "-" + j].ToString();
                }
            }
        }
        catch (NullReferenceException n)
        {
            
        }

        selection = selection - 1;
        Price.Text = "Price: " + a[selection, 0];
        Date.Text = "Date: " + a[selection, 1];
        Time.Text = "Time: " + a[selection, 6];
        DepartAirport.Text = "Departing Airport: " + a[selection, 3];
        DestinationAirport.Text = "Destination Airport: " + a[selection, 4];
        DepartingCity.Text = "Departing City: " + a[selection, 7];
        DestinationCity.Text = "Destination City: " + a[selection, 5];
        PlaneModel.Text = "Plane Model: " + a[selection, 2];

        //selection = selection - 1;
        Response.Write(a[0, 0]);
        Response.Write(a[selection, 0]);
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pay.aspx");
    }
}