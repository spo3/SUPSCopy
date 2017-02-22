<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BusinessSignUp.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="compName" runat="server" OnTextChanged="compName_TextChanged"></asp:TextBox>
        Company Name<p>
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            Desired Username</p>
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
        E-Mail<p>
            <asp:TextBox ID="confirmEmail" runat="server"></asp:TextBox>
            Confirm E-Mail</p>
        <asp:TextBox ID="compAddress" runat="server"></asp:TextBox>
        Company Address<p>
            <asp:TextBox ID="city" runat="server"></asp:TextBox>
        City<p>
            <asp:TextBox ID="state" runat="server"></asp:TextBox>
        State<p>
            <asp:TextBox ID="zip" runat="server"></asp:TextBox>
        Zip Code<p>
            <asp:TextBox ID="phone" runat="server"></asp:TextBox>
            Phone Number</p>
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
        Password<p>
            <asp:TextBox ID="confirmPassword" runat="server"></asp:TextBox>
            Confirm Password</p>
        <asp:Button ID="cancelButton" runat="server" Text="Back" />
        <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
    </form>
</body>
</html>
