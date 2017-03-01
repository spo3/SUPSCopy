using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUpSplit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void ImABusiness_Click(object sender, EventArgs e)
    {
        Response.Redirect("BusinessSignUp");
    }

    protected void ImAPassenger_Click(object sender, EventArgs e)
    {
        Response.Redirect("PassengerSignUp");
    }
}