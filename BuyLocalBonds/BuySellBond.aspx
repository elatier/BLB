<%@ Page Title="dbBLB" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="BuySellBond.aspx.cs" Inherits="BuyLocalBonds.BuyBond" %>

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
        .style15
        {
            height: 20px;
            width: 120px;
        }
        .style16
        {
        }
        .style18
        {
            height: 20px;
            width: 381px;
        }
        .style19
        {
            height: 20px;
            width: 180px;
        }
        .style20
        {
            width: 180px;
        }
        .style23
        {
            height: 20px;
            width: 161px;
        }
        .style24
        {
            width: 161px;
        }
        .style25
        {
            height: 20px;
            width: 125px;
        }
        .style26
        {
            width: 125px;
        }
        .style27
        {
            width: 120px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        &nbsp;<asp:Label ID="HeaderLabel" runat="server" Text="Buy Bond"></asp:Label>
    </h2>
    <table class="style1">
        <tr>
            <td class="style25">
                    <asp:Label ID="Label1" runat="server" Text="CUSIP:"></asp:Label>
                </td>
            <td class="style19">
                    <asp:TextBox ID="CUSIP" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style15">
                    <asp:Label ID="Label31" runat="server" Text="Client Name:"></asp:Label>
                </td>
            <td class="style23">
                    <asp:DropDownList ID="ClientDropdown" runat="server" 
                        DataSourceID="ClientNameDbConnection" DataTextField="client_name" 
                        DataValueField="client_id" >
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="ClientNameDbConnection" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:BLBDataConnectionString %>" 
                        SelectCommand="SELECT [client_id],[client_name] FROM [CLIENT] ORDER BY [client_name]">
                    </asp:SqlDataSource>
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style26">
                    <asp:Label ID="Label2" runat="server" Text="Bond Name:"></asp:Label>
                </td>
            <td class="style20">
                    <asp:TextBox ID="Name" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style27">
                    <asp:Label ID="Label9" runat="server" Text="Price ($):"></asp:Label>
                </td>
            <td class="style24">
                    <asp:TextBox ID="Price" runat="server" Enabled="false"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style26">
                    <asp:Label ID="Label28" runat="server" Text="S&amp;P Rating:"></asp:Label>
                </td>
            <td class="style20">
                    <asp:TextBox ID="Rating" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style27">
                    <asp:Label ID="Label33" runat="server" Text="Quantity Available:"></asp:Label>
                </td>
            <td class="style24">
                    <asp:TextBox ID="QuantityAvailable" runat="server" Enabled="false" ></asp:TextBox>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style25">
                    <asp:Label ID="Label4" runat="server" Text="Coupon (%):"></asp:Label>
                </td>
            <td class="style19">
                    <asp:TextBox ID="Coupon" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style15">
                    <asp:Label ID="Label29" runat="server" Text="Quantity:"></asp:Label>
                </td>
            <td class="style23">
                    <asp:TextBox ID="Quantity" runat="server"  ></asp:TextBox>
            </td>
            <td class="style2">

                <asp:RequiredFieldValidator ID="RequiredQuantityValidator" runat="server" 
                    ErrorMessage="Quantity is required." ControlToValidate="Quantity" Display="Dynamic"></asp:RequiredFieldValidator>

                <asp:RangeValidator ID="QuantityRangeValidator" runat="server" 
                    ErrorMessage="Invalid quantity specified." ControlToValidate="Quantity" MinimumValue="1"
                     Type="Integer" Display="Dynamic"></asp:RangeValidator>
                </td>
        </tr>
        <tr>
            <td class="style25">
                    <asp:Label ID="Label5" runat="server" Text="Current Yield (%):"></asp:Label>
                </td>
            <td class="style19">
                    <asp:TextBox ID="CurrentYield" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style15">
                    <asp:Label ID="TotalAmountLabel" runat="server" Visible="false" Text="Total Amount ($):"></asp:Label>
                    </td>
            <td class="style23">
                    <asp:TextBox ID="TotalAmount" runat="server" Enabled="false" Visible="false"
                        ></asp:TextBox>
                </td>
            <td class="style18">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="style25">
                    <asp:Label ID="Label6" runat="server" Text="YTM (%):"></asp:Label>
                </td>
            <td class="style19">
                    <asp:TextBox ID="YieldToMaturity" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style15">
                    <asp:Label ID="SettleTimeLabel" runat="server" Text="Settlement (t+):" Visible="false"></asp:Label>
                </td>
            <td class="style23">
                    <asp:TextBox ID="SettleTime" runat="server" Enabled="false" Visible="false"></asp:TextBox>
            </td>
            <td class="style2">
                    &nbsp;</td>
        </tr>
        <tr>
            <td class="style26">
                    <asp:Label ID="Label7" runat="server" Text="Maturity Date:"></asp:Label>
                </td>
            <td class="style20">
                    <asp:TextBox ID="MaturityDate" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style27">
                    <asp:Label ID="TransactionIDLabel" runat="server" Text="Transaction ID:" Visible="false" ></asp:Label>
                </td>
            <td class="style24">
                    <asp:TextBox ID="TransactionId" runat="server" Visible="false" Enabled="false" 
                        ></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style26">
                    <asp:Label ID="Label8" runat="server" Text="Par Value ($):"></asp:Label>
                </td>
            <td class="style20">
                    <asp:TextBox ID="ParValue" runat="server" Enabled="false"></asp:TextBox>
                </td>
            <td class="style16" colspan="2">
            <b>
                <asp:Label ID="ConfirmationLabel" runat="server" Text="Your transaction has been submitted." Visible="false"></asp:Label>
                </b>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style25">
                    &nbsp;</td>
            <td class="style19">
                <asp:button id="Back" runat="server" text="Back" 
                    ValidationGroup="None" onclick="Back_Click1" />
                </td>
            <td class="style15">
                    &nbsp;</td>
            <td class="style23">
                <asp:Button ID="Buy" runat="server" Text="Buy" onclick="Buy_Click" 
                     />
                <asp:Button ID="Cancel" runat="server" Text="Amend" onclick="Cancel_Click" 
                    Visible="false"/>
                <asp:Button ID="GoPortfolioButton" runat="server" Text="Client Portfolio" 
                PostBackUrl="~/ClientPortfolio.aspx" Visible="false"/>
            </td>
            <td class="style2">
                <asp:Button ID="Confirm" runat="server" Text="Confirm" 
                    onclick="Confirm_Click" Visible="false" />
            </td>
        </tr>
        <tr>
            <td class="style25">
                    &nbsp;</td>
            <td class="style19">
                    &nbsp;</td>
            <td class="style15">
                    &nbsp;</td>
            <td class="style23">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>
