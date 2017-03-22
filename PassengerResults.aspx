<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PassengerResults.aspx.cs" Inherits="PassengerResults" %>
<link rel="stylesheet" href="style.css" />
<!DOCTYPE html>

<html style="background-color:midnightblue" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="ContainerTable" runat="server" BorderColor="Navy" BorderWidth="5" Width="70%" Height="50%">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Table ID="Result1Table" runat="server" BorderColor="Gray" BorderWidth="2" Width="100%" Height="100%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="result1Price" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result1Date" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result1Plane" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result1Depart" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result1Destination" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result1NearestCity" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Button ID="result1Submit" align="right" runat="server" Text="Details" OnClick="result1Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                        </asp:Table>
               </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Table ID="Result2Table" runat="server" BorderColor="Gray" BorderWidth="2" Width="100%" Height="100%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="result2Price" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result2Date" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result2Plane" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result2Depart" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result2Destination" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result2NearestCity" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Button ID="result2Submit" align="right" runat="server" Text="Details" OnClick="result2Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                        </asp:Table>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Table ID="Result3Table" runat="server" BorderColor="Gray" BorderWidth="2" Width="100%" Height="100%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="result3Price" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result3Date" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result3Plane" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result3Depart" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result3Destination" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result3NearestCity" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Button ID="result3Submit" align="right" runat="server" Text="Details" OnClick="result3Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                        </asp:Table>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Table ID="Result4Table" runat="server" BorderColor="Gray" BorderWidth="2" Width="100%" Height="100%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="result4Price" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result4Date" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result4Plane" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result4Depart" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result4Destination" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result4NearestCity" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Button ID="result4Submit" align="right" runat="server" Text="Details" OnClick="result4Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                        </asp:Table>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Table ID="Result5Table" runat="server" BorderColor="Gray" BorderWidth="2" Width="100%" Height="100%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="result5Price" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result5Date" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result5Plane" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result5Depart" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result5Destination" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result5NearestCity" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Button ID="result5Submit" align="right" runat="server" Text="Details" OnClick="result5Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                        </asp:Table>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Table ID="Result6Table" runat="server" BorderColor="Gray" BorderWidth="2" Width="100%" Height="100%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="result6Price" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result6Date" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result6Plane" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result6Depart" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result6Destination" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result6NearestCity" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Button ID="result6Submit" align="right" runat="server" Text="Details"  OnClick="result6Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                        </asp:Table>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Table ID="Result7Table" runat="server" BorderColor="Gray" BorderWidth="2" Width="100%" Height="100%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="result7Price" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result7Date" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result7Plane" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result7Depart" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result7Destination" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result7NearestCity" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Button ID="result7Submit" align="right" runat="server" Text="Details"  OnClick="result7Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                        </asp:Table>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Table ID="Result8Table" runat="server" BorderColor="Gray" BorderWidth="2" Width="100%" Height="100%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="result8Price" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result8Date" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result8Plane" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result8Depart" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result8Destination" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result8NearestCity" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Button ID="result8Submit" align="right" runat="server" Text="Details"  OnClick="result8Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                        </asp:Table>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Table ID="Result9Table" runat="server" BorderColor="Gray" BorderWidth="2" Width="100%" Height="100%">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="result9Price" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result9Date" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result9Plane" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result9Depart" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result9Destination" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Label ID="result9NearestCity" runat="server" Text="300.00"></asp:Label>&nbsp
                                <asp:Button ID="result9Submit" align="right" runat="server" Text="Details"  OnClick="result9Click"/>
                            </asp:TableCell>
                        </asp:TableRow>
                        </asp:Table>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
