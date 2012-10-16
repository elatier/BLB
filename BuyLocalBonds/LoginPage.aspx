<%@ Page Title="LoginPage" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="LoginPage.aspx.cs" Inherits="BuyLocalBonds.LoginPage" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Login</h2>
    <p>
        Username:
        <asp:TextBox ID="UserName1" runat="server"></asp:TextBox>
    </p>
    <p>
        Password: <asp:TextBox ID="Password1" TextMode="password" runat="server"></asp:TextBox>
    </p>
    <p>
                    <asp:Button ID="LoginButton" runat="server" Text="Login" 
                        onclick="LoginButton_Click" />
                    &nbsp;<asp:TextBox ID="InvalidInputBox" runat="server"></asp:TextBox>
    </p>
<p>
                    &nbsp;</p>
</asp:Content>
