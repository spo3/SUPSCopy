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
        int djdjivoavrIROAaioraADgrHhTHS = 0;
        bool properSecure = false;
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

      //||Company Name Regular Expressions ---------------------------------------------------
        Regex security = new Regex(@"^(.*?(\binsert into\b)[^$]*)$|^(.*?(\b<\b)[^$]*)$|^(.*?(\b>\b)[^$]*)$|^(.*?(\bdelete from\b)[^$]*)$|^(.*?(\balter table\b)[^$]*)$|^(.*?(\bselect *\b)[^$]*)$|^(.*?(\binner join\b)[^$]*)$|^(.*?(\bouter join\b)[^$]*)$|^(.*?(\bequi join\b)[^$]*)$");
        Match companyNameSecurityMatching = security.Match(cn);
        if (companyNameSecurityMatching.Success)
        {
            companyNameFailLabel.Text = "Inappropriate text entered...";
        }
        else { companyNameFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
      //||Username Regular Expressions ---------------------------------------------------
        Match usernameSecurityMatching = security.Match(un);
        if (usernameSecurityMatching.Success)
        {
            usernameFailLabel.Text = "Inappropriate text entered...";
        }
        else { usernameFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
      //||Email Regular Expressions ---------------------------------------------------
        Match emailSecurityMatching = security.Match(em);
        if (emailSecurityMatching.Success)
        {
            emailFailLabel.Text = "Inappropriate text entered...";
        }
        else { emailFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
      //||Company Address Regular Expressions ---------------------------------------------------
        Match companyAddressSecurityMatching = security.Match(ca);
        if (companyAddressSecurityMatching.Success)
        {
            addressFailLabel.Text = "Inappropriate text entered...";
        }
        else { addressFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
      //||Company State Regular Expressions ---------------------------------------------------
        Match companyStateSecurityMatching = security.Match(cs);
        if (companyStateSecurityMatching.Success)
        {
            stateFailLabel.Text = "Inappropriate text entered...";
        }
        else { stateFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
      //||Company City Regular Expressions ---------------------------------------------------
        Match companyCitySecurityMatching = security.Match(cc);
        if (companyCitySecurityMatching.Success)
        {
            cityFailLabel.Text = "Inappropriate text entered...";
        }
        else { cityFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
      //||Company Zip Code Regular Expressions ---------------------------------------------------
        Match companyZipSecurityMatching = security.Match(cz);
        if (companyZipSecurityMatching.Success)
        {
            zipFailLabel.Text = "Inappropriate text entered...";
        }
        else { zipFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
      //||Company Phone Regular Expressions ---------------------------------------------------
        Match companyPhoneSecurityMatching = security.Match(ph);
        if (companyPhoneSecurityMatching.Success)
        {
            phoneFailLabel.Text = "Inappropriate text entered...";
        }
        else { phoneFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
      //||Company Password Regular Expressions ---------------------------------------------------
        Match companyPasswordSecurityMatching = security.Match(pw);
        if (companyPasswordSecurityMatching.Success)
        {
            passwordFailLabel.Text = "Inappropriate text entered...";
        }
        else { passwordFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }

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
        if (djdjivoavrIROAaioraADgrHhTHS == 9)
            properSecure = true;

        SqlConnection writeConnection = new SqlConnection("Data Source=STUSQL; Integrated Security=true");

        if(properSecure == true)
        try
        {
            //----------------------- Configuring database connection ---------------------------//
            writeConnection.Open();
            writeConnection.ChangeDatabase("spo3_CAPSTONE");
            /*-----------------------------------------------------------------------------------*/
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
