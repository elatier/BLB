<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserGuide.aspx.cs" Inherits="BuyLocalBonds.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style4
        {
            text-decoration: underline;
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <span class="style4">dbBLB User Guide</span></p>
    <p>
        <span class="style4">1. Login </span>
    </p>
    <p>
        The user must be logged in to access any of the dbBLB facilities.
    </p>
    <ol>
        <li>Enter a username and password. (Example valid account: Username: [trader1 or 
            trader2] Password: password.) </li>
        <li>Press the Login key.</li>
    </ol>
    <p>
        <span class="style4">2. Buying Bond</span></p>
    <ol>
        <li>Enter the CUSIP code if known, else enter any valid parameter to for an 
            appropriate bond. </li>
        <li>Click the Search button. </li>
        <li>If there is results returned, matching your criteria, press the corresponding 
            &#39;buy&#39; button. </li>
        <li>Review that this is the bond you want and select the client and enter your 
            quantity desired. Note quantitity desired must be less than quantity available.
        </li>
        <li>Press the &#39;buy&#39; button.</li>
    </ol>
    <p>
        <span class="style4">3. View Client Portfolio</span>&nbsp;
    </p>
    <ol>
        <li>Press &#39;View client portfolio&#39; to view the clients currently owned portfolio.
        </li>
        <li>&nbsp;Select the client whose portfolio you want to see and then select &#39;Get 
            Portfolio&#39;. </li>
        <li>Portfolio is displayed in both pie chart and list form.</li>
    </ol>
</asp:Content>
