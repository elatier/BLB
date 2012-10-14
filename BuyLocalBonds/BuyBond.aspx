<%@ Page Title="Buy Bond" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="BuyBond.aspx.cs" Inherits="BuyLocalBonds.BuyBond" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 20px;
        }
        .style5
        {
            height: 20px;
            width: 166px;
        }
        .style6
        {
            width: 166px;
        }
        .style7
        {
            height: 20px;
            width: 173px;
        }
        .style8
        {
            width: 173px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Buy Bond
    </h2>
    <table class="style1">
        <tr>
            <td class="style7">
                    <asp:Label ID="Label1" runat="server" Text="CUSIP:"></asp:Label>
                </td>
            <td class="style5">
                    <asp:TextBox ID="CUSIP" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td class="style8">
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                </td>
            <td class="style6">
                    <asp:TextBox ID="Name" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                    <asp:Label ID="Label28" runat="server" Text="S&amp;P Rating:"></asp:Label>
                </td>
            <td class="style6">
                    <asp:TextBox ID="Rating" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                    <asp:Label ID="Label4" runat="server" Text="Coupon:"></asp:Label>
                </td>
            <td class="style5">
                    <asp:TextBox ID="Coupon" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td class="style7">
                    <asp:Label ID="Label5" runat="server" Text="Current Yield (%):"></asp:Label>
                </td>
            <td class="style5">
                    <asp:TextBox ID="CurrentYield" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td class="style7">
                    <asp:Label ID="Label6" runat="server" Text="Yield To Maturity (%):"></asp:Label>
                </td>
            <td class="style5">
                    <asp:TextBox ID="YieldToMaturity" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td class="style8">
                    <asp:Label ID="Label7" runat="server" Text="Maturity Date:"></asp:Label>
                </td>
            <td class="style6">
                    <asp:TextBox ID="MaturityDate" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                    <asp:Label ID="Label8" runat="server" Text="Par Value ($):"></asp:Label>
                </td>
            <td class="style6">
                    <asp:TextBox ID="ParValue" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                    <asp:Label ID="Label9" runat="server" Text="Price ($):"></asp:Label>
                </td>
            <td class="style5">
                    <asp:TextBox ID="Price" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td class="style8">
                    Quantity Available:</td>
            <td class="style6">
                    <asp:TextBox ID="QuantityAvailable" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr maximumvalue="20">
            <td class="style8">
                    <asp:Label ID="Label29" runat="server" Text="Quantity:"></asp:Label>
                </td>
            <td class="style6">
                    <asp:TextBox ID="Quantity" runat="server"></asp:TextBox>
                </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ErrorMessage="Invalid Quantity" ControlToValidate="Quantity" 
                    SetFocusOnError="True" MinimumValue="1" MaximumValue="20"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                <asp:Button ID="Back" runat="server" Text="Back" onclick="Back_Click" />
            </td>
            <td class="style6">
                <asp:Button ID="Buy" runat="server" Text="Buy" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style6">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
