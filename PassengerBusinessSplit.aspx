<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PassengerBusinessSplit.aspx.cs" Inherits="Default2" %>
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
        <asp:Table ID="Table1" runat="server" Width="100%" Height="40%">
            <asp:TableHeaderRow>
                <asp:TableCell>
                    <asp:Table ID="PassengerTable" runat="server" Width="20%" Height="50%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Button ID="ImAPassenger" runat="server" text="Sign in as passenger" OnClick="ImAPassenger_Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Table ID="BusinessTable" runat="server" Width="20%" Height="50%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Button ID="ImABusiness" runat="server" text="Sign in as business" OnClick="ImABusiness_Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:TableCell>
                <asp:TableCell>

                </asp:TableCell>
                <asp:TableCell>

                </asp:TableCell>
                <asp:TableCell>

                </asp:TableCell>
            </asp:TableHeaderRow>

        </asp:Table>
        
        
    </form>
</body>
</html>
