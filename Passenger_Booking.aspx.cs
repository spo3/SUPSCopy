using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){}

    protected void Button1_Click(object sender, EventArgs e)
    {
        Regex dateControl = new Regex(@"(\d{2}|\d{1})([-]){1}(\d{1}|\d{2})([-]){1}(\d{4})");
        Match dobMatching = dateControl.Match(date.Text);
        if (dobMatching.Success) { }
        else
        {
            dateFailLabel.Text = "Use date format: MM/DD/YYYY";
        }
        try
        {
            string departingAirport = whereFromList.Text;
            string destinationAirport = whereToList.Text;
            string Date = date.Text;
            int numberOfSeats = Convert.ToInt32(numOfSeats.Text);
            bool first = false;
            bool select = false;
            bool economy = false;

            if (seatSelection.SelectedItem.Value == "First Class")
            {
                first = true;
            }
            else
            if (seatSelection.SelectedItem.Value == "Select")
            {
                select = true;
            }
            else
            if (seatSelection.SelectedItem.Value == "Economy")
            {
                economy = true;
            }
        }
        catch(FormatException ex)
        {
            Response.Write(ex.Message);
        }

    }

    protected void date_TextChanged(object sender, EventArgs e){}
}