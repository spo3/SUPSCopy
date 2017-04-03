<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<!DOCTYPE html>

<link rel="stylesheet" href="style.css" />
<html xmlns="http://www.w3.org/1999/xhtml" style="background-color:midnightblue">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcome to the flight details page for flight number:
        <br />
        <asp:Label ID="Price" runat="server" Text="Total Price: "></asp:Label>
        <br />
        Seats Selected:
        <br />
        <asp:Label ID="PlaneModel" runat="server" Text="Plane Model: "></asp:Label>
        <br />
        <asp:Label ID="DepartingCity" runat="server" Text="Departing City: "></asp:Label>
        <br />
        <asp:Label ID="DestinationCity" runat="server" Text="Destination City: "></asp:Label>
        <br />
        <asp:Label ID="Date" runat="server" Text="Date: "></asp:Label>
        <br />
        <asp:Label ID="Time" runat="server" Text="Time: "></asp:Label>
        <br />
        <asp:Label ID="DepartAirport" runat="server" Text="Departing Airport: "></asp:Label>
        <br />
        <asp:Label ID="DestinationAirport" runat="server" Text="Destination Airport: "></asp:Label>
        <br />
    
    </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Book Flight" OnClick="Button1_Click" />
    </form>
</body>
</html>
