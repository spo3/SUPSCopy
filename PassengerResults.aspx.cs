using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PassengerResults : System.Web.UI.Page
{
    string[,] a = new string[20, 20];
    protected void Page_Load(object sender, EventArgs e)
    {
        Table[] tables = new Table[100];
        Label[] prices = new Label[100];
        Label[] dates = new Label[100];
        Label[] planes = new Label[100];
        Label[] departCities = new Label[100];
        Label[] destinationCities = new Label[100];
        

        //Initializing the arrays to be populated with sesssion variables ----------- vvvvvvvvvv
        try {
            int k = 0;

            for(int i = 0; i < 20; i++)
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
        
            //a[0, 0] = Session["results1-0"].ToString();
            //a[0, 1] = Session["results1-1"].ToString();
            //a[0, 2] = Session["results1-2"].ToString();
            //a[0, 3] = Session["results1-3"].ToString();
            //a[0, 4] = Session["results1-4"].ToString();
            //a[0, 5] = Session["results1-5"].ToString();
            //a[0, 6] = Session["results1-6"].ToString();
            //a[0, 7] = Session["results1-7"].ToString();

            //a[1, 0] = Session["results2-0"].ToString();
            //a[1, 1] = Session["results2-1"].ToString();
            //a[1, 2] = Session["results2-2"].ToString();
            //a[1, 3] = Session["results2-3"].ToString();
            //a[1, 4] = Session["results2-4"].ToString();
            //a[1, 5] = Session["results2-5"].ToString();
            //a[1, 6] = Session["results2-6"].ToString();
            //a[1, 7] = Session["results2-7"].ToString();

            //a[2, 0] = Session["results3-0"].ToString();
            //a[2, 1] = Session["results3-1"].ToString();
            //a[2, 2] = Session["results3-2"].ToString();
            //a[2, 3] = Session["results3-3"].ToString();
            //a[2, 4] = Session["results3-4"].ToString();
            //a[2, 5] = Session["results3-5"].ToString();
            //a[2, 6] = Session["results3-6"].ToString();
            //a[2, 7] = Session["results3-7"].ToString();

            //a[3, 0] = Session["results4-0"].ToString();
            //a[3, 1] = Session["results4-1"].ToString();
            //a[3, 2] = Session["results4-2"].ToString();
            //a[3, 3] = Session["results4-3"].ToString();
            //a[3, 4] = Session["results4-4"].ToString();
            //a[3, 5] = Session["results4-5"].ToString();
            //a[3, 6] = Session["results4-6"].ToString();
            //a[3, 7] = Session["results4-7"].ToString();

            //a[4, 0] = Session["results5-0"].ToString();
            //a[4, 1] = Session["results5-1"].ToString();
            //a[4, 2] = Session["results5-2"].ToString();
            //a[4, 3] = Session["results5-3"].ToString();
            //a[4, 4] = Session["results5-4"].ToString();
            //a[4, 5] = Session["results5-5"].ToString();
            //a[4, 6] = Session["results5-6"].ToString();
            //a[4, 7] = Session["results5-7"].ToString();

            //a[5, 0] = Session["results6-0"].ToString();
            //a[5, 1] = Session["results6-1"].ToString();
            //a[5, 2] = Session["results6-2"].ToString();
            //a[5, 3] = Session["results6-3"].ToString();
            //a[5, 4] = Session["results6-4"].ToString();
            //a[5, 5] = Session["results6-5"].ToString();
            //a[5, 6] = Session["results6-6"].ToString();
            //a[5, 7] = Session["results6-7"].ToString();

        //Initializing all price labels
        prices[0] = result1Price;
        prices[1] = result2Price;
        prices[2] = result3Price;
        prices[3] = result4Price;
        prices[4] = result5Price;
        prices[5] = result6Price;
        prices[6] = result7Price;
        prices[7] = result8Price;
        prices[8] = result9Price;

        //Initializing all date labels
        dates[0] = result1Date;
        dates[1] = result2Date;
        dates[2] = result3Date;
        dates[3] = result4Date;
        dates[4] = result5Date;
        dates[5] = result6Date;
        dates[6] = result7Date;
        dates[7] = result8Date;
        dates[8] = result9Date;

        //Initializing all plane labels
        planes[0] = result1Plane;
        planes[1] = result2Plane;
        planes[2] = result3Plane;
        planes[3] = result4Plane;
        planes[4] = result5Plane;
        planes[5] = result6Plane;
        planes[6] = result7Plane;
        planes[7] = result8Plane;
        planes[8] = result9Plane;

        //Initializing all departing cities
        departCities[0] = result1Depart;
        departCities[1] = result2Depart;
        departCities[2] = result3Depart;
        departCities[3] = result4Depart;
        departCities[4] = result5Depart;
        departCities[5] = result6Depart;
        departCities[6] = result7Depart;
        departCities[7] = result8Depart;
        departCities[8] = result9Depart;

        //Initializing all destination cities
        destinationCities[0] = result1Destination;
        destinationCities[1] = result2Destination;
        destinationCities[2] = result3Destination;
        destinationCities[3] = result4Destination;
        destinationCities[4] = result5Destination;
        destinationCities[5] = result6Destination;
        destinationCities[6] = result7Destination;
        destinationCities[7] = result8Destination;
        destinationCities[8] = result9Destination;


        //Initializing all result tables
        tables[0] = Result1Table;
        tables[1] = Result2Table;
        tables[2] = Result3Table;
        tables[3] = Result4Table;
        tables[4] = Result5Table;
        tables[5] = Result6Table;
        tables[6] = Result7Table;
        tables[7] = Result8Table;
        tables[8] = Result9Table;

   //-------------------------------------------------------------------------------------------------------------------------

      //Set all tables invisible except the container table
        ContainerTable.Visible = true;
        Result1Table.Visible = false;
        Result2Table.Visible = false;
        Result3Table.Visible = false;
        Result4Table.Visible = false;
        Result5Table.Visible = false;
        Result6Table.Visible = false;
        Result7Table.Visible = false;
        Result8Table.Visible = false;
        Result9Table.Visible = false;
        

        int numberOfTables = Convert.ToInt32(Session["RESULT_COUNT"]);

        for(int i = 0; i < numberOfTables; i++)
        {
            tables[i].Visible = true;
            prices[i].Text = a[i, 0];
            dates[i].Text = a[i, 1];
            planes[i].Text = a[i, 2];
            departCities[i].Text = a[i, 3];
            destinationCities[i].Text = a[i, 4];
        }

    }
    protected void result1Click(object sender, EventArgs e)
    {
        Session["UserDetailSelection"] = 1;
        Session["THIS_DATE"] = a[1, 1];
        Response.Redirect("Details.aspx");
    }
    protected void result2Click(object sender, EventArgs e)
    {
        Session["UserDetailSelection"] = 2;
        Session["THIS_DATE"] = a[2, 1];
        Response.Redirect("Details.aspx");
    }
    protected void result3Click(object sender, EventArgs e)
    {
        Session["UserDetailSelection"] = 3;
        Session["THIS_DATE"] = a[3, 1];
        Response.Redirect("Details.aspx");
    }
    protected void result4Click(object sender, EventArgs e)
    {
        Session["UserDetailSelection"] = 4;
        Session["THIS_DATE"] = a[4, 1];
        Response.Redirect("Details.aspx");
    }
    protected void result5Click(object sender, EventArgs e)
    {
        Session["UserDetailSelection"] = 5;
        Session["THIS_DATE"] = a[6, 1];
        Response.Redirect("Details.aspx");
    }
    protected void result6Click(object sender, EventArgs e)
    {
        Session["UserDetailSelection"] = 6;
        Session["THIS_DATE"] = a[7, 1];
        Response.Redirect("Details.aspx");
    }
    protected void result7Click(object sender, EventArgs e)
    {
        Session["UserDetailSelection"] = 7;
        Session["THIS_DATE"] = a[8, 1];
        Response.Redirect("Details.aspx");
    }
    protected void result8Click(object sender, EventArgs e)
    {
        Session["UserDetailSelection"] = 8;
        Session["THIS_DATE"] = a[9, 1];
        Response.Redirect("Details.aspx");
    }
    protected void result9Click(object sender, EventArgs e)
    {
        Session["UserDetailSelection"] = 9;
        Session["THIS_DATE"] = a[10, 1];
        Response.Redirect("Details.aspx");
    }
}