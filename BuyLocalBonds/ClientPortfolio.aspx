<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientPortfolio.aspx.cs" Inherits="BuyLocalBonds.ClientPortfolio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="DDLClientID" runat="server" DataSourceID="getClient" 
        DataTextField="client_name" DataValueField="client_id">
    </asp:DropDownList>
    <asp:Button ID="ButtonGo" runat="server" Text="Get Portfolio" 
        onclick="ButtonGo_Click" />
    <asp:SqlDataSource ID="getClient" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BLBDataConnectionString %>" 
        SelectCommand="SELECT [client_id], [client_name] FROM [CLIENT]">
    </asp:SqlDataSource>
    <asp:GridView ID="GV_portfolio" runat="server">
    </asp:GridView>
</asp:Content>
