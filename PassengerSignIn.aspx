<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PassengerSignIn.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Table ID="headerTable" runat="server" Height="60px" Width="100%">
            <asp:TableRow>
                <asp:TableCell>
                    
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
        <p>
            &nbsp;</p>
        <asp:Table ID="containerTable" runat="server" Height="100%" Width="80%">
            <asp:TableHeaderRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Table ID="literalTable" runat="server" Height="100%" Width="20%" HorizontalAlign="right">
                        <asp:TableRow>
                            
                        </asp:TableRow>
                        <asp:TableRow>
                            
                        </asp:TableRow>
                    </asp:Table>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Table ID="LoginTable" runat="server" Height="100%" Width="25%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Literal ID="usernameLiteral" runat="server" Text="Username:"></asp:Literal>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="username" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="wrongUsernameLabel" runat="server" ForeColor="Red" Font-Size="Small"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Literal ID="passwordLiteral" runat="server" Text="Password:"></asp:Literal>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="password" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="wrongPasswordLabel" runat="server" ForeColor="Red" Font-Size="Small"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell HorizontalAlign="Right">
                                <a href="a" runat="server">Sign Up</a>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign="Right">
                                 <asp:Button ID="submitButton" runat="server" text="Submit" OnClick="submitButton_Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>
        
        
    </form>
</body>
</html>
