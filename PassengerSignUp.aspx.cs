using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class PassengerSignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Cancel_Click(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        bool properSecure = true;
        int djdjivoavrIROAaioraADgrHhTHS = 0;
            //----------------------- Variable hiding : database never sees text boxes ----------//
            string un = username.Text;
            string fn = firstName.Text;
            string ln = lastName.Text;
            string em = email.Text;
            string add = address.Text;
            string cit = city.Text;
            string st = state.Text;
            string zi = zip.Text;
            string ph = phone.Text;
            string dob = dateOfBirth.Text;
            string pw = password.Text;
            string pwc = confirmPassword.Text;
            /*-----------------------------------------------------------------------------------*/

            //--//--//--//--//--//--//------     Regular Expressions    --//--//--//--//--//--//--//--//--//--//--//--//--//
            
       //|| Username Regex Checks---------------------------------------------------------------------------
            Regex security = new Regex(@"^(.*?(\binsert into\b)[^$]*)$|^(.*?(\bdelete from\b)[^$]*)$|^(.*?(\balter table\b)[^$]*)$|^(.*?(\bselect *\b)[^$]*)$|^(.*?(\binner join\b)[^$]*)$|^(.*?(\bouter join\b)[^$]*)$|^(.*?(\bequi join\b)[^$]*)$");
            Match usernameSecurityMatching = security.Match(un);
            if (usernameSecurityMatching.Success)
            {
                usernameFailLabel.Text = "Inappropriate text entered...";
            }
            else { usernameFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        //|| First name Regex Checks---------------------------------------------------------------------------
            Match firstNameSecurityMatching = security.Match(fn);
            if (firstNameSecurityMatching.Success)
            {
               firstNameFailLabel.Text = "Inappropriate text entered...";
            }
            else { firstNameFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        //|| Last name Regex Checks---------------------------------------------------------------------------
            Match lastNameSecurityMatching = security.Match(ln);
            if (lastNameSecurityMatching.Success)
            {
                lastNameFailLabel.Text = "Inappropriate text entered...";
            }
            else { lastNameFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        //|| Date of Birth Regex Checks---------------------------------------------------------------------------
            Regex dateControl = new Regex(@"(\d{2}|\d{1})([-]){1}(\d{1}|\d{2})([-]){1}(\d{4})");
            Match dobMatching = dateControl.Match(dob);
            if (dobMatching.Success)
            {
                dobFailLabel.Text = "";
                djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1;
            }
            else
            {
                    dobFailLabel.Text = "Date:    Please enter a valid date in the following format MM-DD-YYYY";
            }
        //|| Email Regex Checks---------------------------------------------------------------------------
        Match emailSecurityMatching = security.Match(em);
            if (emailSecurityMatching.Success)
            {
                emailFailLabel.Text = "Inappropriate text entered...";
            }
            else { emailFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        //|| Address Regex Checks---------------------------------------------------------------------------
            Match addressSecurityMatching = security.Match(add);
            if (addressSecurityMatching.Success)
            {
               addressFailLabel.Text = "Inappropriate text entered...";
            }
            else { addressFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        //|| State Regex Checks---------------------------------------------------------------------------
            Match stateSecurityMatching = security.Match(st);
            if (stateSecurityMatching.Success)
            {
                stateFailLabel.Text = "Inappropriate text entered...";
            }
            else { stateFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        //|| City Regex Checks---------------------------------------------------------------------------
            Match citySecurityMatching = security.Match(cit);
            if (citySecurityMatching.Success)
            {
                cityFailLabel.Text = "Inappropriate text entered...";
            }
            else { cityFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        //|| Zip code Regex Checks---------------------------------------------------------------------------
            Match zipSecurityMatching = security.Match(zi);
            if (zipSecurityMatching.Success)
            {
                zipFailLabel.Text = "Inappropriate text entered...";
            }
            else { zipFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        //|| Phone Regex Checks---------------------------------------------------------------------------
            Match phoneSecurityMatching = security.Match(ph);
            if (phoneSecurityMatching.Success)
            {
                phoneFailLabel.Text = "Inappropriate text entered...";
            }
            else { phoneFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        //|| Password Regex Checks---------------------------------------------------------------------------
            Match passwordSecurityMatching = security.Match(pw);
            if (passwordSecurityMatching.Success)
            {
                passwordFailLabel.Text = "Inappropriate text entered...";
            }
            else { passwordFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        //|| Password Confirm Regex Checks---------------------------------------------------------------------------
            Match passwordConfirmSecurityMatching = security.Match(pw);
            if (passwordConfirmSecurityMatching.Success)
            {
                confirmPasswordFailLabel.Text = "Inappropriate text entered...";
            }
            else { confirmPasswordFailLabel.Text = ""; djdjivoavrIROAaioraADgrHhTHS = djdjivoavrIROAaioraADgrHhTHS + 1; }
        /*------------------------------------------------------------------------------------*/



        if (djdjivoavrIROAaioraADgrHhTHS == 12)
            properSecure = true;
        else
            properSecure = false;




        SqlConnection writeConnection = new SqlConnection("Data Source=STUSQL; Integrated Security=true");
        try
        {
            //----------------------- Configuring database connection ---------------------------//
            if (properSecure)
            {
                writeConnection.Open();
                writeConnection.ChangeDatabase("spo3_CAPSTONE");
                /*-----------------------------------------------------------------------------------*/
                //----------------------- Database insert statements +  ----------------------------------//
                string insertRecords = "insert into PassengerTable values('" + un + "','" + pw + "','" + em + "','"
                    + fn + "','" + ln + "','" + dob + "','" + ph + "','" + add + "','" + cit + "','" + st + "','"
                    + zi + "',null,null,null)";
                SqlCommand accountCreation = new SqlCommand(insertRecords, writeConnection);

                accountCreation.ExecuteNonQuery();
                Response.Write("<p>Successfully Created Account.<p>");
                writeConnection.Close();
            }
            
            /*---------------------------------------------------------------------------------------------------------------------------------*/
        }
        catch (SqlException s)
        {
            Response.Write(s.Number + s.Message);   
        }
        catch(FormatException ex)
        {
            Response.Write(ex.Message);
        }

        }
}