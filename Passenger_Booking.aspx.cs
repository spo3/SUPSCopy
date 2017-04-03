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
    int resultCounter;
    protected string class_;
    protected string[,] a = new string[20,20];
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
        SqlConnection dbConnection = new SqlConnection("Data Source=stusql; Integrated Security=true");
        try
        {
            
            dbConnection.Open();
            dbConnection.ChangeDatabase("spo3_CAPSTONE");

            string passengerSearchString = "Select * from PassengerFlightTable where DepartingName like '" + Convert.ToString(whereFromList.Text) + "' and DestinationName like '" + Convert.ToString(whereToList.Text) + "'";

        SqlCommand getResults = new SqlCommand(passengerSearchString, dbConnection);
        SqlDataReader passengerSearch  = getResults.ExecuteReader();
        
        string databaseRetrievedDeparting;
        string databaseRetrievedDestination;
        string databaseRetrievedDepartDate;
        string databaseRetrievedTime;
        string databaseRetrievedNearestDepartingCity;
        string databaseRetrievedNearestDestinationCity;
        //double databaseRetrievedPrice = 0;
        string databaseRetrievedPlaneModel;
            double databaseConcievedPrice = 0;
            int numberOfSeats;
            double firstClassPrice;
            double selectClassPrice;
            double economyClassPrice;

            /*---------------------------------------------------------------------------------------------------------------------------------*/


            //---------------------- Read through the database until the username is found ----------------------------------------------------//

            if (passengerSearch.Read())
            {
                do
                {
                    numberOfSeats = Convert.ToInt32(numOfSeats.Text);
                    firstClassPrice = Convert.ToDouble(passengerSearch["FirstClassPrice"].ToString());
                    selectClassPrice = Convert.ToDouble(passengerSearch["SelectClassPrice"].ToString());
                    economyClassPrice = Convert.ToDouble(passengerSearch["EconomyClassPrice"].ToString());


                    databaseRetrievedDeparting = passengerSearch["DepartingName"].ToString();
                    databaseRetrievedDestination = passengerSearch["DestinationName"].ToString();
                    databaseRetrievedDepartDate = passengerSearch["DepartDate"].ToString();
                    databaseRetrievedTime = passengerSearch["DepartTime"].ToString();
                    databaseRetrievedNearestDepartingCity = passengerSearch["DepartingNearestCity"].ToString();
                    databaseRetrievedNearestDestinationCity = passengerSearch["DestinationNearestCity"].ToString();
                    databaseRetrievedPlaneModel = passengerSearch["PlaneModel"].ToString();
                    
                    if (class_ == "First") { databaseConcievedPrice = numberOfSeats * firstClassPrice; }
                    else
                    if (class_ == "Select") { databaseConcievedPrice = numberOfSeats * selectClassPrice; }
                    else
                    if (class_ == "Economy") { databaseConcievedPrice = numberOfSeats * economyClassPrice; }

                    



                    if (databaseRetrievedDeparting == whereFromList.Text)
                    {
                        if (databaseRetrievedDestination == whereToList.Text)
                        {
                            if (dateCheckBox.Checked)
                            {
                                if (databaseRetrievedDepartDate == dateBox.Text)
                                {
                                    resultCounter++;
                                    Session["RESULT_COUNT"] = resultCounter;
                                    a[resultCounter, 1] = databaseRetrievedDepartDate;
                                    a[resultCounter, 6] = databaseRetrievedTime;
                                    a[resultCounter, 3] = databaseRetrievedDeparting;
                                    a[resultCounter, 4] = databaseRetrievedDestination;
                                    a[resultCounter, 5] = databaseRetrievedNearestDepartingCity;
                                    a[resultCounter, 7] = databaseRetrievedNearestDestinationCity;
                                    a[resultCounter, 2] = databaseRetrievedPlaneModel;
                                    a[resultCounter, 0] = Convert.ToString(databaseConcievedPrice);
                                    PutInSession(resultCounter);
                                    //Response.Write("Works");
                                }
                            }else
                            {
                                resultCounter++;
                                Session["RESULT_COUNT"] = resultCounter;
                                a[resultCounter, 1] = databaseRetrievedDepartDate;
                                a[resultCounter, 6] = databaseRetrievedTime;
                                a[resultCounter, 3] = databaseRetrievedDeparting;
                                a[resultCounter, 4] = databaseRetrievedDestination;
                                a[resultCounter, 7] = databaseRetrievedNearestDepartingCity;
                                a[resultCounter, 5] = databaseRetrievedNearestDestinationCity;
                                a[resultCounter, 2] = databaseRetrievedPlaneModel;
                                a[resultCounter, 0] = Convert.ToString(databaseConcievedPrice);
                                PutInSession(resultCounter);
                                //Response.Write("Works");
                            }
                        }
                    }
                } while (passengerSearch.Read());
            }
        }



        //If any exceptions occur, 
        catch (SqlException s)
        {
            Response.Write(s.Message);
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
        Response.Redirect("PassengerResults.aspx");
    }
    protected void PutInSession(int results)
    {
        switch (results)
        {
            case 1:
                Session["results1-0"] = a[1, 0];
                Session["results1-1"] = a[1, 1];
                Session["results1-2"] = a[1, 2];
                Session["results1-3"] = a[1, 3];
                Session["results1-4"] = a[1, 4];
                Session["results1-5"] = a[1, 5];
                Session["results1-6"] = a[1, 6];
                Session["results1-7"] = a[1, 7];
                break;
            case 2:
                Session["results2-0"] = a[2, 0];
                Session["results2-1"] = a[2, 1];
                Session["results2-2"] = a[2, 2];
                Session["results2-3"] = a[2, 3];
                Session["results2-4"] = a[2, 4];
                Session["results2-5"] = a[2, 5];
                Session["results2-6"] = a[2, 6];
                Session["results2-7"] = a[2, 7];
                break;
            case 3:
                Session["results3-0"] = a[3, 0];
                Session["results3-1"] = a[3, 1];
                Session["results3-2"] = a[3, 2];
                Session["results3-3"] = a[3, 3];
                Session["results3-4"] = a[3, 4];
                Session["results3-5"] = a[3, 5];
                Session["results3-6"] = a[3, 6];
                Session["results3-7"] = a[3, 7];
                break;
            case 4:
                Session["results4-0"] = a[4, 0];
                Session["results4-1"] = a[4, 1];
                Session["results4-2"] = a[4, 2];
                Session["results4-3"] = a[4, 3];
                Session["results4-4"] = a[4, 4];
                Session["results4-5"] = a[4, 5];
                Session["results4-6"] = a[4, 6];
                Session["results4-7"] = a[4, 7];
                break;
            case 5:
                Session["results5-0"] = a[5, 0];
                Session["results5-1"] = a[5, 1];
                Session["results5-2"] = a[5, 2];
                Session["results5-3"] = a[5, 3];
                Session["results5-4"] = a[5, 4];
                Session["results5-5"] = a[5, 5];
                Session["results5-6"] = a[5, 6];
                Session["results5-7"] = a[5, 7];
                break;
            case 6:
                Session["results6-0"] = a[6, 0];
                Session["results6-1"] = a[6, 1];
                Session["results6-2"] = a[6, 2];
                Session["results6-3"] = a[6, 3];
                Session["results6-4"] = a[6, 4];
                Session["results6-5"] = a[6, 5];
                Session["results6-6"] = a[6, 6];
                Session["results6-7"] = a[6, 7];
                break;
            case 7:
                Session["results7-0"] = a[7, 0];
                Session["results7-1"] = a[7, 1];
                Session["results7-2"] = a[7, 2];
                Session["results7-3"] = a[7, 3];
                Session["results7-4"] = a[7, 4];
                Session["results7-5"] = a[7, 5];
                Session["results7-6"] = a[7, 6];
                Session["results7-7"] = a[7, 7];

                break;
            case 8:
                Session["results8-0"] = a[8, 0];
                Session["results8-1"] = a[8, 1];
                Session["results8-2"] = a[8, 2];
                Session["results8-3"] = a[8, 3];
                Session["results8-4"] = a[8, 4];
                Session["results8-5"] = a[8, 5];
                Session["results8-6"] = a[8, 6];
                Session["results8-7"] = a[8, 7];
                break;
            case 9:
                Session["results9-0"] = a[9, 0];
                Session["results9-1"] = a[9, 1];
                Session["results9-2"] = a[9, 2];
                Session["results9-3"] = a[9, 3];
                Session["results9-4"] = a[9, 4];
                Session["results9-5"] = a[9, 5];
                Session["results9-6"] = a[9, 6];
                Session["results9-7"] = a[9, 7];
                break;
                case 10:
                Session["results10-0"] = a[10, 0];
                Session["results10-1"] = a[10, 1];
                Session["results10-2"] = a[10, 2];
                Session["results10-3"] = a[10, 3];
                Session["results10-4"] = a[10, 4];
                Session["results10-5"] = a[10, 5];
                Session["results10-6"] = a[10, 6];
                Session["results10-7"] = a[10, 7];
                break;
            case 11:
                Session["results11-0"] = a[11, 0];
                Session["results11-1"] = a[11, 1];
                Session["results11-2"] = a[11, 2];
                Session["results11-3"] = a[11, 3];
                Session["results11-4"] = a[11, 4];
                Session["results11-5"] = a[11, 5];
                Session["results11-6"] = a[11, 6];
                Session["results11-7"] = a[11, 7];
                break;
            case 12:
                Session["results12-0"] = a[12, 0];
                Session["results12-1"] = a[12, 1];
                Session["results12-2"] = a[12, 2];
                Session["results12-3"] = a[12, 3];
                Session["results12-4"] = a[12, 4];
                Session["results12-5"] = a[12, 5];
                Session["results12-6"] = a[12, 6];
                Session["results12-7"] = a[12, 7];
                break;
            case 13:
                Session["results13-0"] = a[13, 0];
                Session["results13-1"] = a[13, 1];
                Session["results13-2"] = a[13, 2];
                Session["results13-3"] = a[13, 3];
                Session["results13-4"] = a[13, 4];
                Session["results13-5"] = a[13, 5];
                Session["results13-6"] = a[13, 6];
                Session["results13-7"] = a[13, 7];
                break;
            case 14:
                Session["results14-0"] = a[14, 0];
                Session["results14-1"] = a[14, 1];
                Session["results14-2"] = a[14, 2];
                Session["results14-3"] = a[14, 3];
                Session["results14-4"] = a[14, 4];
                Session["results14-5"] = a[14, 5];
                Session["results14-6"] = a[14, 6];
                Session["results14-7"] = a[14, 7];
                break;
            case 15:
                Session["results15-0"] = a[15, 0];
                Session["results15-1"] = a[15, 1];
                Session["results15-2"] = a[15, 2];
                Session["results15-3"] = a[15, 3];
                Session["results15-4"] = a[15, 4];
                Session["results15-5"] = a[15, 5];
                Session["results15-6"] = a[15, 6];
                Session["results15-7"] = a[15, 7];
                break;
            case 16:
                Session["results16-0"] = a[16, 0];
                Session["results16-1"] = a[16, 1];
                Session["results16-2"] = a[16, 2];
                Session["results16-3"] = a[16, 3];
                Session["results16-4"] = a[16, 4];
                Session["results16-5"] = a[16, 5];
                Session["results16-6"] = a[16, 6];
                Session["results16-7"] = a[16, 7];
                break;
            case 17:
                Session["results17-0"] = a[17, 0];
                Session["results17-1"] = a[17, 1];
                Session["results17-2"] = a[17, 2];
                Session["results17-3"] = a[17, 3];
                Session["results17-4"] = a[17, 4];
                Session["results17-5"] = a[17, 5];
                Session["results17-6"] = a[17, 6];
                Session["results17-7"] = a[17, 7];
                break;
            case 18:
                Session["results18-0"] = a[18, 0];
                Session["results18-1"] = a[18, 1];
                Session["results18-2"] = a[18, 2];
                Session["results18-3"] = a[18, 3];
                Session["results18-4"] = a[18, 4];
                Session["results18-5"] = a[18, 5];
                Session["results18-6"] = a[18, 6];
                Session["results18-7"] = a[18, 7];
                break;
            case 19:
                Session["results19-0"] = a[19, 0];
                Session["results19-1"] = a[19, 1];
                Session["results19-2"] = a[19, 2];
                Session["results19-3"] = a[19, 3];
                Session["results19-4"] = a[19, 4];
                Session["results19-5"] = a[19, 5];
                Session["results19-6"] = a[19, 6];
                Session["results19-7"] = a[19, 7];
                break;
            case 20:
                Session["results20-0"] = a[20, 0];
                Session["results20-1"] = a[20, 1];
                Session["results20-2"] = a[20, 2];
                Session["results20-3"] = a[20, 3];
                Session["results20-4"] = a[20, 4];
                Session["results20-5"] = a[20, 5];
                Session["results20-6"] = a[20, 6];
                Session["results20-7"] = a[20, 7];
                break;
        }
    }


    protected void date_TextChanged(object sender, EventArgs e) { }
}

    
