﻿<%@ Page Title="Search Bonds" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="BuyLocalBonds._Default" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

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
        .style11
        {
            width: 160px;
        }
        .style12
        {
            height: 20px;
            width: 160px;
        }
        .style14
        {
            height: 20px;
            width: 145px;
        }
        .style15
        {
            width: 145px;
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
                <td class="style15">
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
                    <asp:Label ID="Label1" runat="server" Text="CUSIP:" 
                        meta:resourcekey="Label1Resource1"></asp:Label>
                </td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    <asp:TextBox ID="CUSIP" runat="server" meta:resourcekey="CUSIPResource1" ></asp:TextBox>
                </td>
                <td class="style14">
                    <asp:RegularExpressionValidator ID="CUSIP_Validator" runat="server" 
                        ControlToValidate="CUSIP" ErrorMessage="Invalid CUSIP" 
                        ValidationExpression="[0-9]{3}[a-zA-Z0-9]{6}" 
                        meta:resourcekey="CUSIP_ValidatorResource1"></asp:RegularExpressionValidator>
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
                    <asp:Label ID="Label2" runat="server" Text="Name:" 
                        meta:resourcekey="Label2Resource1"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    <asp:TextBox ID="Name" runat="server" meta:resourcekey="NameResource1" ></asp:TextBox>
                </td>
                <td class="style15">
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
                    <asp:Label ID="Label28" runat="server" Text="S&amp;P Rating:" 
                        meta:resourcekey="Label28Resource1"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="low" 
                        meta:resourcekey="Label12Resource1"></asp:Label>
                </td>
                <td class="style5">
                    <asp:DropDownList ID="RatingLow1" runat="server" 
                        DataSourceID="RatingDbConnection" DataTextField="rating_sp" 
                        DataValueField="rating_sp" meta:resourcekey="RatingLow1Resource1">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="RatingDbConnection" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:BLBDataConnectionString %>" 
                        SelectCommand="SELECT [rating_sp] FROM [RATINGS] ORDER BY [rating]">
                    </asp:SqlDataSource>
                </td>
                <td class="style15">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label21" runat="server" Text="high" 
                        meta:resourcekey="Label21Resource1"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:DropDownList ID="RatingHigh1" runat="server" 
                        DataSourceID="RatingDbConnection" DataTextField="rating_sp" 
                        DataValueField="rating_sp" meta:resourcekey="RatingHigh1Resource1">
                    </asp:DropDownList>
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
                    <asp:Label ID="Label4" runat="server" Text="Coupon:" 
                        meta:resourcekey="Label4Resource1"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="low" 
                        meta:resourcekey="Label13Resource1"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="CouponLow" runat="server" 
                        meta:resourcekey="CouponLowResource1"></asp:TextBox>
                </td>
                <td class="style15">
                    <asp:RegularExpressionValidator ID="ParValue_v6" runat="server" 
                        ControlToValidate="CouponLow" ErrorMessage="Invalid Coupon Low" 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$" 
                        meta:resourcekey="ParValue_v6Resource1"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="high" 
                        meta:resourcekey="Label22Resource1"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="CouponHigh" runat="server" 
                        meta:resourcekey="CouponHighResource1"></asp:TextBox>
                </td>
                <td class="style11">
                    <asp:RegularExpressionValidator ID="ParValue_v7" runat="server" 
                        ControlToValidate="CouponHigh" ErrorMessage="Invalid Coupon High" 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$" 
                        meta:resourcekey="ParValue_v7Resource1"></asp:RegularExpressionValidator>
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
                    <asp:Label ID="Label5" runat="server" Text="Current Yield (%):" 
                        meta:resourcekey="Label5Resource1"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="low" 
                        meta:resourcekey="Label14Resource1"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="CurrentYieldLow" runat="server" 
                        meta:resourcekey="CurrentYieldLowResource1"></asp:TextBox>
                </td>
                <td class="style15">
                    <asp:RegularExpressionValidator ID="ParValue_v4" runat="server" 
                        ControlToValidate="CurrentYieldLow" ErrorMessage="Invalid Low Current Yield " 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$" 
                        meta:resourcekey="ParValue_v4Resource1"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Label ID="Label23" runat="server" Text="high" 
                        meta:resourcekey="Label23Resource1"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="CurrentYieldHigh" runat="server" 
                        meta:resourcekey="CurrentYieldHighResource1"></asp:TextBox>
                </td>
                <td class="style11">
                    <asp:RegularExpressionValidator ID="ParValue_v5" runat="server" 
                        ControlToValidate="CurrentYieldHigh" ErrorMessage="Invalid High Current Yield " 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$" 
                        meta:resourcekey="ParValue_v5Resource1"></asp:RegularExpressionValidator>
                  </td>
                <td>
                    <asp:Button ID="SearchButton" runat="server" Text="Search" 
                        onclick="SearchButton_Click" meta:resourcekey="SearchButtonResource1" />
                </td>
                <td>
                    </td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="16px" 
                        meta:resourcekey="ValidationSummary1Resource1" />
                </td>
                <td>
                    </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label6" runat="server" Text="Yield To Maturity (%):" 
                        meta:resourcekey="Label6Resource1"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="low" 
                        meta:resourcekey="Label15Resource1"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="YieldToMaturityLow" runat="server" 
                        meta:resourcekey="YieldToMaturityLowResource1"></asp:TextBox>
                </td>
                <td class="style15">
                    <asp:RegularExpressionValidator ID="ParValue_v3" runat="server" 
                        ControlToValidate="YieldToMaturityLow" ErrorMessage="Invalid Low Yield To Maturity " 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$" 
                        meta:resourcekey="ParValue_v3Resource1"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Label ID="Label24" runat="server" Text="high" 
                        meta:resourcekey="Label24Resource1"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="YieldToMaturityHigh" runat="server" 
                        meta:resourcekey="YieldToMaturityHighResource1"></asp:TextBox>
                </td>
                <td class="style11">
                    <asp:RegularExpressionValidator ID="ParValue_v2" runat="server" 
                        ControlToValidate="YieldToMaturityHigh" ErrorMessage="Invalid High Yield To Maturity " 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$" 
                        meta:resourcekey="ParValue_v2Resource1"></asp:RegularExpressionValidator>
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
                    <asp:Label ID="Label7" runat="server" Text="Maturity Date:" 
                        meta:resourcekey="Label7Resource1"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="low" 
                        meta:resourcekey="Label16Resource1"></asp:Label>
                </td>
                <td class="style5">
                    <asp:Calendar ID="MaturityDateLow" runat="server" 
                        meta:resourcekey="MaturityDateLowResource1"></asp:Calendar>
                </td>
                <td class="style15">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label25" runat="server" Text="high" 
                        meta:resourcekey="Label25Resource1"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:Calendar ID="MaturityDateHigh" runat="server" 
                        meta:resourcekey="MaturityDateHighResource1"></asp:Calendar>
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
                    <asp:Label ID="Label8" runat="server" Text="Par Value ($):" 
                        meta:resourcekey="Label8Resource1"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label17" runat="server" Text="low" 
                        meta:resourcekey="Label17Resource1"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="ParValueLow" runat="server" 
                        meta:resourcekey="ParValueLowResource1"></asp:TextBox>
                </td>
                <td class="style15">
                    <asp:RegularExpressionValidator ID="ParValue_v0" runat="server" 
                        ControlToValidate="ParValueLow" ErrorMessage="Invalid Low Par Price" 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$" 
                        meta:resourcekey="ParValue_v0Resource1"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Label ID="Label26" runat="server" Text="high" 
                        meta:resourcekey="Label26Resource1"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="ParValueHigh" runat="server" 
                        meta:resourcekey="ParValueHighResource1"></asp:TextBox>
                </td>
                <td class="style11">
                    <asp:RegularExpressionValidator ID="ParValue_v1" runat="server" 
                        ControlToValidate="ParValueHigh" ErrorMessage="Invalid High Par Price" 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$" 
                        meta:resourcekey="ParValue_v1Resource1"></asp:RegularExpressionValidator>
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
                    <asp:Label ID="Label9" runat="server" Text="Price ($):" 
                        meta:resourcekey="Label9Resource1"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label18" runat="server" Text="low" 
                        meta:resourcekey="Label18Resource1"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="PriceLow" runat="server" meta:resourcekey="PriceLowResource1" ></asp:TextBox>
                </td>
                <td class="style15">
                    <asp:RegularExpressionValidator ID="PriceLow_v" runat="server" 
                        ControlToValidate="PriceLow" ErrorMessage="Invalid Low Price" 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$" 
                        meta:resourcekey="PriceLow_vResource1"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Label ID="Label27" runat="server" Text="high" 
                        meta:resourcekey="Label27Resource1"></asp:Label>
                    </td>
                <td class="style7">
                    <asp:TextBox ID="PriceHigh" runat="server" meta:resourcekey="PriceHighResource1" 
                        ></asp:TextBox>
                </td>
                <td class="style11">
                    <asp:RegularExpressionValidator ID="PriceHigh_v" runat="server" 
                        ControlToValidate="PriceHigh" ErrorMessage="Invalid High Price" 
                        SetFocusOnError="True" ValidationExpression="^(\-)?\d*(\.\d+)?$" 
                        meta:resourcekey="PriceHigh_vResource1"></asp:RegularExpressionValidator></td>
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
                <td class="style15">
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
        <asp:GridView ID="BondGrid" onrowcommand="BondGrid_RowCommand" 
            runat="server" meta:resourcekey="BondGridResource1" >
            <columns>        
              <asp:hyperlinkfield datatextfield="cusip"
                datatextformatstring="{0}"
                datanavigateurlfields="cusip"
                datanavigateurlformatstring="~\BuyBond.aspx?CUSIP={0}"          
                headertext="cusip" meta:resourcekey="HyperLinkFieldResource1"
               />
                <asp:buttonfield buttontype="Button" 
                commandname="SelectBond"
                headertext="Buy Bond" 
                text="Buy" meta:resourcekey="ButtonFieldResource1"/>

              
        </columns>
        </asp:GridView>
    </div>
    <p>
                
</p>
    <p>
        &nbsp;</p>
</asp:Content>
