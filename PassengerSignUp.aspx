<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PassengerSignUp.aspx.cs" Inherits="PassengerSignUp" %>
<link rel="stylesheet" href="style.css" />
<html xmlns="http://www.w3.org/1999/xhtml" style="background-color:midnightblue">
<!DOCTYPE html>

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="ContainerTable" runat="server" Width="100%" Height="40%">
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="usernameLabel" runat="server">Username: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="username" runat="server"></asp:TextBox><asp:Label ID="usernameFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="fnLabel" runat="server">First Name: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="firstName" runat="server"></asp:TextBox><asp:Label ID="firstNameFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="lnLabel" runat="server">Last Name: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="lastName" runat="server"></asp:TextBox><asp:Label ID="lastNameFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="emailLabel" runat="server">Email: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="email" runat="server"></asp:TextBox><asp:Label ID="emailFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="confirmEmailLabel" runat="server">Confirm Email: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="confirmEmail" runat="server"></asp:TextBox><asp:Label ID="confirmEmailFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="addressLabel" runat="server">Address: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="address" runat="server"></asp:TextBox><asp:Label ID="addressFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="cityLabel" runat="server">City: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="city" runat="server"></asp:TextBox><asp:Label ID="cityFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="stateLabel" runat="server">State: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="state" runat="server"></asp:TextBox><asp:Label ID="stateFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="zipLabel" runat="server">Zip Code: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="zip" runat="server"></asp:TextBox><asp:Label ID="zipFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="phoneLabel" runat="server">Phone: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="phone" runat="server"></asp:TextBox><asp:Label ID="phoneFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="dobLabel" runat="server" CssClass="whiteText">Date of Birth: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="dateOfBirth" runat="server"></asp:TextBox><asp:Label ID="dobFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell><asp:Label ID="labelllll" runat="server"></asp:Label></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="passwordLabel" runat="server" ValidateRequestMode="Inherit">Create Password: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="password" runat="server" Text=" "></asp:TextBox><asp:Label ID="passwordFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="confirmPasswordLabel" runat="server">Confirm Password: </asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="confirmPassword" runat="server"></asp:TextBox><asp:Label ID="confirmPasswordFailLabel" runat="server" ForeColor="Red" Text=" "></asp:Label>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Cancel" runat="server" Text="Back" OnClick="Cancel_Click" />
                </asp:TableCell>
                <asp:TableCell>
                     <asp:Button ID="Submit" runat="server" Text="Create Account" OnClick="Submit_Click" />
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
       
        
       
    </form>
</body>
</html>
