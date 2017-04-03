<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pay.aspx.cs" Inherits="Pay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color:midnightblue">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <div style="margin-left: 240px">
                <asp:Label ID="TitleLabel" runat="server" Font-Size="20pt" ForeColor="White" Text="Purchase Flight #"></asp:Label>
                <br />
                <br />
                <asp:Label ID="CreditCardLabel" runat="server" ForeColor="White" Text="Credit Card Number: "></asp:Label>
&nbsp;&nbsp;
                <asp:TextBox ID="CardNumber" runat="server" Width="176px"></asp:TextBox>
                <br />
                <asp:Label ID="DateLabel" runat="server" ForeColor="White" Text="Card Expiration Date: "></asp:Label>
&nbsp;
                <asp:TextBox ID="ExpirationDate" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="CVVLabel" runat="server" ForeColor="White" Text="Card CVV Number: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="CVVNumber" runat="server" Width="77px" PasswordChar="*" UseSystemPasswordChar ="true" Font-Strikeout="False"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Purchase" runat="server" Text="Purchase" OnClick="Purchase_Click" />
            </div>
        
    </form>
</body>
</html>
