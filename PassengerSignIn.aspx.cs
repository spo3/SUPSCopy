using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.ComponentModel;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    

    protected void submitButton_Click(object sender, EventArgs e)
    {
      //Clearing the UN and PW fail messages
        wrongUsernameLabel.Text = "";
        wrongPasswordLabel.Text = "";

        SqlConnection dbConnection = new SqlConnection("Data Source=STUSQL; Integrated Security=true");
        try
        {
//----------------------- Configuring database connection ---------------------------//
            dbConnection.Open();
            dbConnection.ChangeDatabase("spo3_CAPSTONE");
/*-----------------------------------------------------------------------------------*/


//----------------------- Creating a query to gather all data from each record in PassengerTable, CargoTable, and AdminTable ----------------------------------//
            string passengerCheck = "Select * from PassengerTable";
            
            SqlCommand passengerPassword = new SqlCommand(passengerCheck, dbConnection);
            SqlDataReader allPassengerUsernames = passengerPassword.ExecuteReader();

            //string cargoCheck = "Select * from PassengerTable";
            //SqlCommand cargoPassword = new SqlCommand(cargoCheck, dbConnection);
            //SqlDataReader allCargoUsernames = cargoPassword.ExecuteReader();

            bool usernameCorrect = false;
          
            string databaseRetrievedUsername;
            string databaseRetrievedPassword;
/*---------------------------------------------------------------------------------------------------------------------------------*/


//---------------------- Read through the database until the username is found ----------------------------------------------------//
            if (allPassengerUsernames.Read())
            {
                do
                {
                  //Assign the next username and password retrieved form the database to a string to then compare to user text field input vv
                    databaseRetrievedUsername = allPassengerUsernames["Username"].ToString();
                    databaseRetrievedPassword = allPassengerUsernames["Password_"].ToString();

                    

                    // IF the username the user entered is in the database, the second IF statement will execute to check that the associated password is correct
                    // Since the IF statements are not directly accessing the database, this configuration of string comparison is secure
                    if (databaseRetrievedUsername == username.Text)
                    {
                      //if the below boolean value is true, and the user types the wrong password, only the password will have red text beside it
                        usernameCorrect = true;
                        if (databaseRetrievedPassword == password.Text)
                        {
                            string getUserID = "Select userid from PassengerTable where username = " + databaseRetrievedUsername;
                            //SqlCommand getSessionUserID = new SqlCommand(getUserID, dbConnection);
                            //SqlDataReader sessionIDReader = getSessionUserID.ExecuteReader();
                            
                            Session["SESSION_USERID"] = allPassengerUsernames["UserID"].ToString();
                            Response.Write("Works");
                            Response.Write(Session["SESSION_USERID"]);

                            Response.Redirect("Passenger_Booking.aspx");
                        }
                    }
                }
                while (allPassengerUsernames.Read());

              //If the username the user provided was not in the database, the following message will display
              //The password label will always be incorrect when the page is reloaded as a result of pressing submit
                if(usernameCorrect == false)
                wrongUsernameLabel.Text = "Username is incorrect";

                wrongPasswordLabel.Text = "Password is incorrect";
            }
/*---------------------------------------------------------------------------------------------------------------------------------*/
        }
//If any exceptions occur, 
        catch(SqlException s)
        {
            //Response.Write(s.ErrorCode);
            //Response.Write(s.Message);

            /*
            NetworkCredential login;
            SmtpClient client;
            MailMessage msg;
            string mySmtp = "smtp.gmail.com";
            login = new NetworkCredential("oleanshane", "MYPASSWORD");
            client = new SmtpClient(mySmtp);
            client.Port = Convert.ToInt32(587);
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress("oleanshane" + mySmtp.Replace("smtp.", "@"), "Shane", Encoding.UTF8) };
            msg.To.Add(new MailAddress("oleanshane@gmail.com"));
            if (!string.IsNullOrEmpty("spo3@students.ptcollege.edu"))
                msg.To.Add(new MailAddress("spo3@students.ptcollege.edu"));
            msg.Subject = "Trouble Ticket";
            msg.Body = s.ErrorCode + "\n" + s.Message;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);
            */

        }
    }
    /*
    private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
    {
        throw new NotImplementedException();
    }
    */
    protected void backClick(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}