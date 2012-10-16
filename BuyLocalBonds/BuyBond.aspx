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
        .style9
        {
            width: 173px;
            height: 26px;
        }
        .style10
        {
            width: 166px;
            height: 26px;
        }
        .style11
        {
            height: 26px;
        }
        .style12
        {
            height: 20px;
            width: 248px;
        }
        .style13
        {
            width: 248px;
        }
        .style14
        {
            height: 26px;
            width: 248px;
        }
        .style15
        {
            height: 20px;
            width: 122px;
        }
        .style16
        {
            width: 122px;
        }
        .style17
        {
            width: 122px;
            height: 26px;
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
            <td class="style15">
                    <asp:Label ID="Label32" runat="server" Text="Settlement Time (t+)"></asp:Label>
                </td>
            <td class="style12">
                    <asp:TextBox ID="SettleTime" runat="server" Enabled="false"></asp:TextBox>
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                    <asp:Label ID="Label2" runat="server" Text="Bond Name:"></asp:Label>
                </td>
            <td class="style6">
                    <asp:TextBox ID="Name" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style16">
                    &nbsp;</td>
            <td class="style13">
                &nbsp;</td>
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
            <td class="style16">
                    &nbsp;</td>
            <td class="style13">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                    <asp:Label ID="Label4" runat="server" Text="Coupon (%):"></asp:Label>
                </td>
            <td class="style5">
                    <asp:TextBox ID="Coupon" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style15">
                    &nbsp;</td>
            <td class="style12">
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                    <asp:Label ID="Label5" runat="server" Text="Current Yield (%):"></asp:Label>
                </td>
            <td class="style5">
                    <asp:TextBox ID="CurrentYield" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style15">
                    &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                    <asp:Label ID="Label6" runat="server" Text="Yield To Maturity (%):"></asp:Label>
                </td>
            <td class="style5">
                    <asp:TextBox ID="YieldToMaturity" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style15">
                    &nbsp;</td>
            <td class="style12">
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                    <asp:Label ID="Label7" runat="server" Text="Maturity Date:"></asp:Label>
                </td>
            <td class="style6">
                    <asp:TextBox ID="MaturityDate" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style16">
                    &nbsp;</td>
            <td class="style13">
                &nbsp;</td>
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
            <td class="style16">
                    &nbsp;</td>
            <td class="style13">
                &nbsp;</td>
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
            <td class="style15">
                    &nbsp;</td>
            <td class="style12">
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                    <asp:Label ID="Label31" runat="server" Text="Client Name:"></asp:Label>
                </td>
            <td class="style5">
                    <asp:DropDownList ID="ClientDropdown" runat="server" 
                        DataSourceID="ClientNameDbConnection" DataTextField="client_name" 
                        DataValueField="client_id" >
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="ClientNameDbConnection" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:BLBDataConnectionString %>" 
                        SelectCommand="SELECT [client_id],[client_name] FROM [CLIENT] ORDER BY [client_name]">
                    </asp:SqlDataSource>
            </td>
            <td class="style15">
                    &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                    Quantity Available:</td>
            <td class="style6">
                    <asp:TextBox ID="QuantityAvailable" runat="server" Enabled="false" ></asp:TextBox>
                </td>
            <td class="style16">
                    &nbsp;</td>
            <td class="style13">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                    <asp:Label ID="Label29" runat="server" Text="Quantity:"></asp:Label>
                </td>
            <td class="style10">
                    <asp:TextBox ID="Quantity" runat="server"  ></asp:TextBox>
                </td>
            <td class="style17">
                    &nbsp;</td>
            <td class="style14">

                <asp:RequiredFieldValidator ID="RequiredQuantityValidator" runat="server" 
                    ErrorMessage="Quantity is required." ControlToValidate="Quantity" Display="Dynamic"></asp:RequiredFieldValidator>

                <asp:RangeValidator ID="QuantityRangeValidator" runat="server" 
                    ErrorMessage="Quantity specified is invalid." ControlToValidate="Quantity" MinimumValue="1"
                     Type="Integer" Display="Dynamic"></asp:RangeValidator>
            </td>
            <td class="style11">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                    <asp:Label ID="Label30" runat="server" Text="Total Amount ($):"></asp:Label>
                </td>
            <td class="style6">
                    <asp:TextBox ID="TotalAmount" runat="server" Enabled="false" 
                        ></asp:TextBox>
                </td>
            <td class="style16">
                    &nbsp;</td>
            <td class="style13">
            <b>
                <asp:Label ID="ConfirmationLabel" runat="server" Text="Your transaction has been submitted:" Visible="false"></asp:Label>
                </b>
            </td>
            <td>
                <asp:DetailsView ID="DetailsView1" runat="server" Height="16px" Width="125px">
                </asp:DetailsView>
            </td>
        </tr>
        <tr>
            <td class="style8">
                <asp:Button ID="Back" runat="server" Text="Return to Search" onclick="Back_Click" ValidationGroup="None" />
            </td>
            <td class="style6">
                <asp:Button ID="Buy" runat="server" Text="Buy" onclick="Buy_Click" 
                     />
                <asp:Button ID="Cancel" runat="server" Text="Amend" onclick="Cancel_Click" 
                    Visible="false"/>
            </td>
            <td class="style16">
                &nbsp;</td>
            <td class="style13">
                <asp:Button ID="Confirm" runat="server" Text="Confirm" 
                    onclick="Confirm_Click" Visible="false" />
                <asp:Button ID="PortfolioButton" runat="server" Text="View Client Portfolio" 
                    Visible="false" onclick="PortfolioButton_Click"/>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td class="style16">
                &nbsp;</td>
            <td class="style13">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
