<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>
<link rel="stylesheet" href="style.css" />
<html style="background-color:midnightblue" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SUPS Aircraft Service</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1 style="text-decoration:underline">SUPS Aircraft Service</h1>
    <ul id="nav">
        <li><a href="HomePage.aspx">Home</a></li>
        <li><a href="PassengerSignIn.aspx">Sign-In</a></li>
        <li><a href="PassengerSignIn.aspx">Sign-Up</a></li>
        <li style="display:none">Log-Out</li>
    </ul>
    <p>Welcome to our company's home page.
        <br />We provide air travel for both 
        <em style="font-weight:bold;color:goldenrod">people</em> and 
        <em style="font-weight:bold;color:goldenrod">shipments</em> nationally in the United States. We have a wide variety of aircrafts to choose from for both passenger and cargo.</p>
    </form>
</body>
</html>
