using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Pay : System.Web.UI.Page
{
    private int userID;
    protected void Page_Load(object sender, EventArgs e)
    {
        userID = Convert.ToInt32(Session["SESSION_USERID"]);
        Response.Write(userID);

        SqlConnection CardConnection = new SqlConnection("Data Source=STUSQL; Integrated Security=true");
        try
        {
            CardConnection.Open();
            CardConnection.ChangeDatabase("spo3_CAPSTONE");
            string cardCheck = "Select * from PassengerTable where userid = " + userID;

            SqlCommand Checking = new SqlCommand(cardCheck, CardConnection);
            SqlDataReader CardChecking = Checking.ExecuteReader();

            string databaseRetrievedCardNumber = "";
            string databaseRetrievedExpirationDate = "";
            string databaseRetrievedCVVNumber = "";

            if (CardChecking.Read())
            {
                do
                {
                    if (Convert.ToInt32(CardChecking["UserID"]) == userID)
                    {
                        databaseRetrievedCardNumber = CardChecking["Credit_Card_Number"].ToString();
                        databaseRetrievedExpirationDate = CardChecking["Card_Expiration"].ToString(); ;
                        databaseRetrievedCVVNumber = CardChecking["Card_CVV"].ToString(); ;
                    }
                }
                while (CardChecking.Read());
            }
            if (databaseRetrievedCardNumber != null && databaseRetrievedCVVNumber != null && databaseRetrievedExpirationDate != null)
            {
                CardNumber.BackColor = System.Drawing.Color.Yellow;
                ExpirationDate.BackColor = System.Drawing.Color.Yellow;
                CVVNumber.BackColor = System.Drawing.Color.Yellow;

                CardNumber.Text = databaseRetrievedCardNumber;
                ExpirationDate.Text = databaseRetrievedExpirationDate;
                CVVNumber.Text = databaseRetrievedCVVNumber;
            }
        }
        catch (SqlException s)
        {
            Response.Write(s.Message);
        }
    }

    protected void Purchase_Click(object sender, EventArgs e)
    {
        Response.Redirect("ThankYou.aspx");
    }
}