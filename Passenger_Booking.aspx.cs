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
        Match dobMatching = dateControl.Match(dateBox.Text);
        if (dobMatching.Success) { }
        else
        {
            dateFailLabel.Text = "Use date format: MM/DD/YYYY";
        }

        try
        {
            string departingAirport = whereFromList.Text;
            string destinationAirport = whereToList.Text;
            string Date = dateBox.Text;
            string class_;
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
            if (economy == true)
                class_ = "Economy";
            if (select == true)
                class_ = "Select";
            if (first == true)
                class_ = "First";
            //else throw (FormatException);
        }
        catch(FormatException ex)
        {
            Response.Write(ex.Message);
        }

        SqlConnection writeConnection = new SqlConnection("Data Source=STUSQL; Integrated Security=true");

        try
        {
            //----------------------- Configuring database connection ---------------------------//
            writeConnection.Open();
            writeConnection.ChangeDatabase("spo3_CAPSTONE");
            /*-----------------------------------------------------------------------------------*/
            string insertRecords = "insert into CargoTable values('" + "','";
            SqlCommand accountCreation = new SqlCommand(insertRecords, writeConnection);

            accountCreation.ExecuteNonQuery();
            writeConnection.Close();
            Response.Write("<p>Successfully Created Book.<p>");
            Response.Redirect("BusinessBooking.aspx");

            /*---------------------------------------------------------------------------------------------------------------------------------*/

        }
        catch (SqlException s)
        {

        }

    }

    protected void date_TextChanged(object sender, EventArgs e){}
}