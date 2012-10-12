<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="BuyLocalBonds._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 188px;
        }
        .style3
        {
            width: 188px;
            height: 20px;
        }
        .style4
        {
            height: 20px;
        }
        .style5
        {
            width: 146px;
        }
        .style7
        {
            width: 155px;
        }
        .style8
        {
            width: 155px;
            height: 20px;
        }
        .style9
        {
            width: 156px;
        }
        .style10
        {
            height: 20px;
            width: 156px;
        }
        .style11
        {
            width: 96px;
        }
        .style12
        {
            height: 20px;
            width: 96px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Bond Search
    </h2>
    <div>

        <table class="style1">
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td class="style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label1" runat="server" Text="CUSIP:"></asp:Label>
                </td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    <asp:TextBox ID="CUSIP" runat="server" ></asp:TextBox>
                </td>
                <td class="style10">
                    <asp:RegularExpressionValidator ID="CUSIP_Validator" runat="server" 
                        ControlToValidate="CUSIP" ErrorMessage="Invalid CUSIP" 
                        ValidationExpression="[0-9]{3}[a-zA-Z0-9]{6}"></asp:RegularExpressionValidator>
                </td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style8">
                    &nbsp;</td>
                <td class="style12">
                    </td>
                <td class="style4">
                    </td>
                <td class="style4">
                    </td>
                <td class="style4">
                    </td>
                <td class="style4">
                    </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    <asp:TextBox ID="Name" runat="server" ></asp:TextBox>
                </td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td class="style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label3" runat="server" Text="Rating:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="low"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label21" runat="server" Text="high"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                </td>
                <td class="style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label4" runat="server" Text="Coupon:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="low"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="high"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                </td>
                <td class="style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label5" runat="server" Text="Current Yield (%):"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="low"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label23" runat="server" Text="high"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                </td>
                <td class="style11">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="SearchButton" runat="server" Text="Search" 
                        onclick="SearchButton_Click" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="16px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label6" runat="server" Text="Yield To Maturity (%):"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="low"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label24" runat="server" Text="high"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                </td>
                <td class="style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label7" runat="server" Text="Maturity Date:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="low"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label25" runat="server" Text="high"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                </td>
                <td class="style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label8" runat="server" Text="Par Value ($):"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label17" runat="server" Text="low"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="ParValueLow" runat="server"></asp:TextBox>
                </td>
                <td class="style9">
                    <asp:RegularExpressionValidator ID="ParValue_v0" runat="server" 
                        ControlToValidate="ParValueLow" ErrorMessage="Invalid Low Par Price" 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Label ID="Label26" runat="server" Text="high"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="ParValueHigh" runat="server"></asp:TextBox>
                </td>
                <td class="style11">
                    <asp:RegularExpressionValidator ID="ParValue_v1" runat="server" 
                        ControlToValidate="ParValueHigh" ErrorMessage="Invalid High Par Price" 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label9" runat="server" Text="Price ($):"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label18" runat="server" Text="low"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="PriceLow" runat="server" ></asp:TextBox>
                </td>
                <td class="style9">
                    <asp:RegularExpressionValidator ID="PriceLow_v" runat="server" 
                        ControlToValidate="PriceLow" ErrorMessage="Invalid Low Price" 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Label ID="Label27" runat="server" Text="high"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="PriceHigh" runat="server" 
                        ></asp:TextBox>
                </td>
                <td class="style11">
                    <asp:RegularExpressionValidator ID="PriceHigh_v" runat="server" 
                        ControlToValidate="PriceHigh" ErrorMessage="Invalid High Price" 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$"></asp:RegularExpressionValidator></td>
                <td> 
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td class="style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>
        <asp:GridView ID="BondGrid" runat="server">
        </asp:GridView>
    </div>
    <p>
        &nbsp;&nbsp; &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
