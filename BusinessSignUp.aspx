<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BusinessSignUp.aspx.cs" Inherits="_Default" %>
<link rel="stylesheet" href="style.css" />
<html xmlns="http://www.w3.org/1999/xhtml" style="background-color:midnightblue">
<!DOCTYPE html>

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Table ID="containerTable" runat="server" Width="100%">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="compNameLabel" runat="server" Text="Comapny Name: "></asp:Label> &nbsp;&nbsp;
                    <asp:TextBox ID="compName" runat="server" OnTextChanged="compName_TextChanged"></asp:TextBox>
                    <asp:Label ID="companyNameFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="usernameLabel" runat="server" Text="Username: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="username" runat="server"></asp:TextBox>
                    <asp:Label ID="usernameFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    <asp:Label ID="emailFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="confirmEmailLabel" runat="server" Text="Confirm Email: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="confirmEmail" runat="server"></asp:TextBox>
                    <asp:Label ID="confirmEmailFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="addressLabel" runat="server" Text="Address: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="compAddress" runat="server"></asp:TextBox>
                    <asp:Label ID="addressFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="cityLabel" runat="server" Text="City: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="city" runat="server"></asp:TextBox>
                    <asp:Label ID="cityFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="stateLabel" runat="server" Text="State: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="state" runat="server"></asp:TextBox>
                    <asp:Label ID="stateFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="zipLabel" runat="server" Text="Zip Code: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="zip" runat="server"></asp:TextBox>
                    <asp:Label ID="zipFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="phoneLabel" runat="server" Text="Phone Number: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="phone" runat="server"></asp:TextBox>
                    <asp:Label ID="phoneFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="passwordLabel" runat="server" Text="Password: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="password" runat="server"></asp:TextBox>
                    <asp:Label ID="passwordFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="confirmPasswordLabel" runat="server" Text="Confirm Password: "></asp:Label>
                    <asp:TextBox ID="confirmPassword" runat="server"></asp:TextBox>
                    <asp:Label ID="comfirmPasswordFailLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="cancelButton" runat="server" Text="Back" />
                    <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
