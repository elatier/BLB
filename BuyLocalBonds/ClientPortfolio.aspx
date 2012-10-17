<%@ Page Title="dbBLB" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientPortfolio.aspx.cs" Inherits="BuyLocalBonds.ClientPortfolio" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
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
    <br />
<table class="style1">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
    <asp:GridView ID="GV_portfolio" runat="server" onrowcommand="GV_portfolio_RowCommand"
                         >
            <columns>        
                <asp:buttonfield buttontype="Button" 
                    commandname="SelectBond"
                    headertext="Sell Bond" 
                    text="Sell" meta:resourcekey="ButtonFieldResource1"/>
           
        </columns>
    </asp:GridView>
        </td>
        <td>
    <asp:Chart ID="Chart1" runat="server">
        <series>
            <asp:Series ChartType="Pie" Name="Series1">
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </chartareas>
    </asp:Chart>
        </td>
    </tr>
</table>
<br />
</asp:Content>
