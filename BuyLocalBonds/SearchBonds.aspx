<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchBonds.aspx.cs" Inherits="BuyLocalBonds.SearchBonds" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 128px;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
            width: 128px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    Buy Local Bonds: Bond Search<table class="style1">
        <tr>
            <td class="style2">
                </td>
            <td class="style2">
                </td>
            <td class="style2">
                </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                CUSIP</td>
            <td>
                <asp:TextBox ID="CUSIP" runat="server" ></asp:TextBox>
                </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="PriceLow" Display="Dynamic" 
                    ErrorMessage="Price Low Required"></asp:RequiredFieldValidator>
            </td>
            <td class="style1">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="CUSIP" Display="Dynamic" ErrorMessage="CUSIP not correct" 
                    ValidationExpression="[0-9]{3}[a-zA-Z0-9]{6}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Low"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="PriceLow" runat="server"></asp:TextBox>
                </td>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="High"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="PriceHigh" runat="server" 
                    ></asp:TextBox>

            </td>
            <td>
                &nbsp;</td>
            <td class="style1">
                <asp:Button ID="Search" runat="server" Text="Button" onclick="Search_Click" 
                    Height="22px" />
            </td>
        </tr>
    </table>
                <asp:GridView ID="GvBondResults" runat="server" />

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
