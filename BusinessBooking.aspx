<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BusinessBooking.aspx.cs" Inherits="BusinessBooking" %>
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
        <asp:TextBox ID="date" runat="server"></asp:TextBox>
        <asp:Label ID="dateFailLabel" runat="server" ForeColor="Red" Text="" ></asp:Label>
        <br />
        <br />
        How Many Pounds?<br />
        <asp:TextBox ID="p" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="cancel" runat="server" Text="Cancel" />
        <asp:Button ID="search" runat="server" OnClick="Search_Click" Text="Search" />
        <br />
    </div>
    </form>
</body>
</html>
