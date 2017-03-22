<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Passenger_Booking.aspx.cs" Inherits="_Default" %>
<link rel="stylesheet" href="style.css" />
<html xmlns="http://www.w3.org/1999/xhtml" style="background-color:midnightblue">
<!DOCTYPE html>

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Booking a Flight?<br />
        <br />
        Where From?<br />
        <asp:DropDownList ID="whereFromList" runat="server" DataSourceID="SqlDataSource1" DataTextField="AirportName" DataValueField="AirportName">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:spo3_CAPSTONEConnectionString %>" SelectCommand="SELECT [AirportName] FROM [AirportTable] ORDER BY [AirportName]"></asp:SqlDataSource>
        <br />
        <br />
        Where To?<br />
        <asp:DropDownList ID="whereToList" runat="server" DataSourceID="SqlDataSource2" DataTextField="AirportName" DataValueField="AirportName">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:spo3_CAPSTONEConnectionString2 %>" SelectCommand="SELECT [AirportName] FROM [AirportTable] ORDER BY [AirportName]"></asp:SqlDataSource>
        <br />
        <br />
        When?<br />
        <asp:TextBox ID="dateBox" runat="server"></asp:TextBox>
        <asp:Label ID="dateFailLabel" runat="server" ForeColor="Red" Text="" ></asp:Label>
        <br />
        <asp:CheckBox ID="dateCheckBox" runat="server" Text="Check for this date only" />
        <br />
        <br />
        How Many Seats?<br />
        <asp:TextBox ID="numOfSeats" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButtonList ID="seatSelection" runat="server">
            <asp:ListItem>First Class</asp:ListItem>
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Economy</asp:ListItem>
        </asp:RadioButtonList>
    
        <br />
        <asp:Button ID="searchButton" runat="server" OnClick="Button1_Click" Text="Search" />
    
    </div>
    </form>
</body>
</html>
