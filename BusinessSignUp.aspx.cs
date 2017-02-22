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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        //--//--//---/-/-//-/--/-/SET UP REGULAR EXPRESSIONS IN THIS METHOD//--//--//--//--//--//--//--//--//

        SqlConnection writeConnection = new SqlConnection("Data Source=STUSQL; Integrated Security=true");
        try
        {
            //----------------------- Configuring database connection ---------------------------//
            writeConnection.Open();
            writeConnection.ChangeDatabase("spo3_CAPSTONE");
            /*-----------------------------------------------------------------------------------*/


            //----------------------- Variable hiding : database never sees text boxes ----------//
            string cn = compName.Text;
            string un = username.Text;
            string em = email.Text;
            string ca = compAddress.Text;
            string cs = state.Text;
            string cc = city.Text;
            string cz = zip.Text;
            string ph = phone.Text;
            string pw = password.Text;

            /*-----------------------------------------------------------------------------------*/

            //-------------------     Regular Expressions    -------------------------------------//
            //Regex dateControl = new Regex(@"(\d{2}|\d{1})([-]){1}(\d{1}|\d{2})([-]){1}(\d{4})");
            //Match dobMatching = dateControl.Match(dob);
            //if (dobMatching.Success)
            //{
            //    dobFailLabel.Text = "";
            //}
            //else
            //{
            //    dobFailLabel.Text = "Date:    Please enter a valid date in the following format MM-DD-YYYY";
            //}
            /*------------------------------------------------------------------------------------*/

            //-----------------------  ----------------------------------//
            string insertRecords = "insert into CargoTable values('" + un + "','" + cn + "','" + ca + "','" + cc + "','" + cs + "','" + cz + "','" + ph + "','" + em + "','" + pw + "',null,null,null)";
            SqlCommand accountCreation = new SqlCommand(insertRecords, writeConnection);

            accountCreation.ExecuteNonQuery();
            Response.Write("<p>Successfully Created Account.<p>");

            /*---------------------------------------------------------------------------------------------------------------------------------*/
        }
        catch (SqlException s)
        {
            Response.Write(s.Number + s.Message);
        }

    }

    protected void compName_TextChanged(object sender, EventArgs e)
    {

    }
}
